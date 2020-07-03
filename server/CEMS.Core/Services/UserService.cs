using CEMS.Core.DTOs;
using CEMS.Core.Domain.Repositories;
using CEMS.Core.Domain.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using OtpNet;
using System.Security.Cryptography;
using CEMS.Core.SharedServices;
using CEMS.Core.Exceptions;

namespace CEMS.Core.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IUnitOfWork _unitOfWork;

        public UserService(IUserRepository userRepository, IUnitOfWork unitOfWork)
        {
            _userRepository = userRepository;
            _unitOfWork = unitOfWork;
        }
        public async Task<SignupResponseDto> SignupsUserAsync(SignupDto signup)
        {
            // Use the User ID to retrieve the user that is not verified
            var user = await _userRepository.FindByIdAsync(signup.UserId);
            if (user == null)
            {
                throw new BusinessException("User ID does not exist.");
            } else if (user.IsInitialised)
            {
                throw new BusinessException("User is already initialised.");
            }

            // Initialise generator for later
            var generator = RandomNumberGenerator.Create();

            // Name validation
            if (signup.Name.Length < 3 || signup.Name.Length > 64)
            {
                throw new BusinessException("Name length must be between 4-64 characters.");
            }

            // Password validation
            if (signup.Password.Length == 2048)
            {
                throw new BusinessException("Josh, let's not get ahead of ourselves.");
            }
            else if (signup.Password.Length < 10 || signup.Password.Length > 1024)
            {
                throw new BusinessException("Password must be between 10-1024 characeters.");
            }

            // Check if MFA is required
            if (user.MFAEnabled)
            {
                // Generate a new TOTP Code
                if (user.TOTPSecret == "" || signup.MFACode == "")
                {
                    // Generate TOTP
                    
                    byte[] rndArray = new byte[30];
                    generator.GetBytes(rndArray);
                    // var totpSecret = ByteStringConversion.ToString(rndArray);
                    var totpSecret = Base32Encoding.ToString(rndArray);
                    if (totpSecret == null || totpSecret == "")
                    {
                        throw new BusinessException("Error when trying to create MFA code for user, please tell Dave there is an issue.");
                    }

                    // Add it to user
                    user.TOTPSecret = totpSecret;

                    // Save the user
                    _userRepository.Update(user);
                    await _unitOfWork.CompleteAsync();

                    // Return TOTP value
                    return new SignupResponseDto(false, totpSecret);
                } else // Attempt to validate incoming code
                {
                    var totp = new Totp(Base32Encoding.ToBytes(user.TOTPSecret));
                    long timeWindowUsed = 0;
                    var isValid = totp.VerifyTotp(signup.MFACode, out timeWindowUsed, VerificationWindow.RfcSpecifiedNetworkDelay);
                    if (!isValid)
                    {
                        throw new BusinessException("The MFA Code provided was not valid. Please try again.");
                    }
                }
                
            }

            // If all previous requirements are met:
            // generate the salt
            byte[] saltRndArray = new byte[32];
            generator.GetBytes(saltRndArray);
            var salt = ByteStringConversion.ToString(saltRndArray);

            // hash the salt and password
            var hashedPassword = "";
            using (SHA256 sha256Hash = SHA256.Create())
            {
                // ComputeHash - returns byte array  
                byte[] hashedPasswordByteArray = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(salt + signup.Password));
                hashedPassword = ByteStringConversion.ToString(hashedPasswordByteArray);

            }
            // set the salt and password hash for the user
            if (salt != "" || hashedPassword != "")
            {
                user.PasswordSalt = salt;
                user.PasswordHash = hashedPassword;
            }
            // Set the name
            user.Name = signup.Name;
            // Set the initialised flag
            user.IsInitialised = true;

            _userRepository.Update(user);
            await _unitOfWork.CompleteAsync();
            return new SignupResponseDto(true, "");
        }
    }
}
