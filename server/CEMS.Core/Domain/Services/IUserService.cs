using CEMS.Core.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CEMS.Core.Domain.Services
{
    public interface IUserService
    {
        Task<SignupResponseDto> SignupsUserAsync(SignupDto signup);
    }
}
