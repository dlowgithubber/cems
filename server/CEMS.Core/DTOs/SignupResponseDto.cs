using System;
using System.Collections.Generic;
using System.Text;

namespace CEMS.Core.DTOs
{
    public class SignupResponseDto
    {
        public bool IsCompleted { get; set; }
        public string TOTPSecret { get; set; }

        public SignupResponseDto()
        {
        }

        public SignupResponseDto(bool isCompleted, string tOTPSecret)
        {
            IsCompleted = isCompleted;
            TOTPSecret = tOTPSecret;
        }
    }
}
