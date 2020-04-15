using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using CvApi.Services;
using CvApi.Models;
using System.Linq;

namespace CvApi.Controllers
{
    [Authorize]
    [ApiController]
    [Route("auth")]
    public class UsersController : ControllerBase
    {
        private IUserService _userService;

        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

        [AllowAnonymous]
        [HttpPost("authenticate")]
        public IActionResult Authenticate([FromBody] Authenticate model)
        {
            var user = _userService.Authenticate(model.Username, model.Password);

            if (user == null)
                return BadRequest(new { message = "Username or password is incorrect" });

            return Ok(user);
        }

        /// <summary>
        /// Get all users without passwords.
        /// </summary>
        [HttpGet]
        public IActionResult GetAll()
        {
            var users = _userService.GetAll();
            return Ok(users);
        }
    }
}