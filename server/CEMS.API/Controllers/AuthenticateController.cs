using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CEMS.Core.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CEMS.Core.Interfaces.Services;


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

        [HttpPost("signup")]
        public async Task<ActionResult<SignupResponseDto>> SignupUser([FromBody]SignupDto signupDetails)
        {
            // Handle HTTP requests
            // Validate incoming models
            // Pass on to the relevant service
            // Catch any errors
            // Return response with valid codes
            try
            {
                if (signupDetails == null)
                {
                    return BadRequest("No signup details provided");
                }

                if (!ModelState.IsValid)
                {
                    return BadRequest("Invalid model object");
                }

                //additional code
                var response = await _userService.SignupsUserAsync(signupDetails);
                return response;
            }
            catch (Exception ex)
            {
                // _logger.LogError($"Something went wrong inside the CreateOwner action: {ex}");
                return StatusCode(500, "Internal server error");
            }
            throw new NotImplementedException();
        }

        [HttpPost("mfasetup")]
        public IActionResult SetupMFA()
        {
            throw new NotImplementedException();
        }

        [HttpPost("mfaresponse")]
        public IActionResult MFAResponse()
        {
            throw new NotImplementedException();
        }
    }
}
