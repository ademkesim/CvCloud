using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using Entities.Dtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PoldyCvAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AutoController : ControllerBase
    {
        private IAutoService _autoService;

        public AutoController(IAutoService autoService)
        {
            _autoService = autoService;
        }


        [HttpPost("login")]
        public IActionResult Login(UserForLoginDto userForLoginDto)
        {
            var userToLogin = _autoService.Login(userForLoginDto);
            if (!userToLogin.Success)
            {
                return BadRequest(userToLogin.Message);
            }

            var result = _autoService.CreateAccessToken(userToLogin.Data);
            if (result.Success)
            {
                return Ok(result.Data);
            }

            return BadRequest(result.Message);
        }

        [HttpPost("register")]
        public IActionResult Register(UserForRegisterDto userForRegisterDto)
        {
            var userExsits = _autoService.UserExists(userForRegisterDto.Mail);
            if (!userExsits.Success)
            {
                return BadRequest(userExsits.Message);
            }

            var registerResult = _autoService.Register(userForRegisterDto, userForRegisterDto.Password);
            var result = _autoService.CreateAccessToken(registerResult.Data);
            if (result.Success)
            {
                return Ok(result.Data);

            }

            return BadRequest(result.Message);

        }
    }
}