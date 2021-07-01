using System;
using Labo2ASPdotNet.Models;
using Labo2ASPdotNet.Models.Entities;
using Labo2ASPdotNet.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Labo2ASPdotNet.Areas.Api.Controllers
{
   [Area("Api")]
    public class UserController : Controller
    {
        private readonly IUserService userService;

        public UserController(IUserService userService)
        {
            this.userService = userService;
        }

        [Route("/Api/Users/Login")]
        [HttpPost]
        public IActionResult Login([FromBody] LoginModel model)
        {
            var response = userService.Authenticate(model);

            if (response == null)
            {
                return BadRequest(new { message = "Username or password none correctly" });
            }

            return Ok(response);
        }

        
        [Route("/Api/Admin/Login")]
        [HttpPost]
        public IActionResult LoginAdmin([FromBody] LoginModel model)
        {
            var response = userService.Authenticate(model);

            if (response != null)
            {
                if (response.AccontType == Role.Admin)
                    return Ok(response);
                else
                {
                    return Forbid("Permission deinied!");
                }
            }
            return Unauthorized("Unauthorized!");
            
        }
    }
}
