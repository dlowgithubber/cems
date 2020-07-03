using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CEMS.Core.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CEMS.Core.Domain.Services;
using CEMS.Core.Exceptions;

namespace CEMS.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class AuthenticateController : ControllerBase
    {
        private readonly IUserService _userService;
        
        public AuthenticateController(IUserService userService)
        {
            _userService = userService;
        }
        
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2" };
        }

        [HttpGet("test")]
        public IActionResult GetAll()
        {
            return StatusCode(201, "Thank You.");
        }

        [HttpPost("login")]
        public IActionResult LoginUser()
        {
            throw new NotImplementedException();
        }

        [HttpPost("mfaresponse")]
        public ActionResult MFAResponse()
        {
            throw new NotImplementedException();
        }

        [HttpPost("signup")]
        public async Task<ActionResult<SignupResponseDto>> SignupUser([FromBody]SignupDto signupDetails)
        {
            // Handle HTTP requests
            // Validate incoming models
            // Pass on to the relevant service
            // Catch any errors
            // Return response with valid codes
            if (signupDetails == null)
            {
                throw new BusinessException("No signup details provided");
            }

            if (!ModelState.IsValid)
            {
                throw new BusinessException("Invalid model object");
            }

            //additional code
            var response = await _userService.SignupsUserAsync(signupDetails);
            return response;
            
        }

        [HttpPost("mfasetup")]
        public IActionResult SetupMFA([FromBody] SignupDto signupDetails)
        {
            throw new NotImplementedException();
        }
    }
}
