using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using Core.Entities.Concrte;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PoldyCvAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private IPersonService _personService;

        public PersonController(IPersonService personService)
        {
            _personService = personService;
        }

        [HttpPost("add")]
        public IActionResult Add(Person person)
        {
            var UserToCheck = _personService.UserExists(person.Mail);
            if (UserToCheck.Success)
            {
                return BadRequest(UserToCheck.Message);
            }
            var UserAdd = _personService.Add(person);

            if (UserAdd.Success)
            {
                return Ok(UserAdd.Message);
            }
            return BadRequest(UserAdd.Message);

        }


        [HttpPost("delete")]
        public IActionResult Delete(Person person)
        {
            var UserToCheck = _personService.UserExists(person.Mail);
            if (!UserToCheck.Success)
            {
                return BadRequest(UserToCheck.Message);
            }
            var UserDelete = _personService.Delete(person);

            if (UserDelete.Success)
            {
                return Ok(UserDelete.Message);
            }
            return BadRequest(UserDelete.Message);

        }



        [HttpPost("update")]
        public IActionResult Update(Person person)
        {
            var UserToCheck = _personService.UserExists(person.Mail);
            if (!UserToCheck.Success)
            {
                return BadRequest(UserToCheck.Message);
            }
            var UserUpdate = _personService.Update(person);

            if (UserUpdate.Success)
            {
                return Ok(UserUpdate.Message);
            }
            return BadRequest(UserUpdate.Message);

        }



        [HttpGet("getall")]
        public IActionResult GetList()
        {
            var UserGet = _personService.GetList();
            if (UserGet.Success)
            {
                return Ok(UserGet.Data);
            }
            return BadRequest(UserGet.Message);
        }



        [HttpGet("getbymail")]
        public Person GetByMail(string mail)
        {

            return _personService.GetByMail(mail);
        }



    }
}