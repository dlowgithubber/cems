using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CEMS.Core.DTOs
{
    public class SignupDto
    {
        [Required(ErrorMessage = "User ID is required")]
        [MinLength(1, ErrorMessage = "User ID must be at least one character")]
        public string UserId { get; set; }

        [Required(ErrorMessage = "Name is required")]
        [MinLength(3, ErrorMessage = "Name must be at least three characters")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [MinLength(10, ErrorMessage = "Password must be at least ten characters")]
        public string Password { get; set; }
        
        public string MFACode { get; set; }

        public SignupDto()
        {
        }
    }
}
