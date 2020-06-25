using CEMS.Core.DTOs;
using CEMS.Core.Interfaces.Repositories;
using CEMS.Core.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CEMS.Core.Domain.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public async Task<SignupResponseDto> SignupsUserAsync(SignupDto signup)
        {
            // Use the User ID to retrieve the user that is not verified
            // If a valid user returns, verify that the password meets expectations
            // Check whether MFA is required. If so, generate a TOTP value and send it as a response.
            // If not, send a confirmation message of signup, set as initialised.
            // Save changes to the database.
            var response = new SignupResponseDto(true, "");
            return await Task.FromResult(response);
        }
    }
}
