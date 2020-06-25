using CEMS.Core.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CEMS.Core.Interfaces.Services
{
    public interface IUserService
    {
        Task<SignupResponseDto> SignupsUserAsync(SignupDto signup);
    }
}
