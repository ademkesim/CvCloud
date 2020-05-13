using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace PoldyCvAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CurriculumVitaeController : Controller
    {
        private ICurriculumVitaeService _curriculumVitaeService;

        public CurriculumVitaeController(ICurriculumVitaeService curriculumVitaeService)
        {
            _curriculumVitaeService = curriculumVitaeService;
        }
        [HttpPost("add")]
        public IActionResult Add(CurriculumVitae curriculumVitae, int id)
        {
            var result = _curriculumVitaeService.Add(curriculumVitae, id);
            if (result.Success)
            {
                return Ok(result.Message);

            }

            return BadRequest(result.Message);
        }
        [HttpPost("update")]
        public IActionResult Update(CurriculumVitae curriculumVitae)
        {
            var result = _curriculumVitaeService.Update(curriculumVitae);
            if (result.Success)
            {
                return Ok(result.Message);
            }

            return BadRequest(result.Message);
        }
        [HttpPost("delete")]
        public IActionResult Delete(CurriculumVitae curriculumVitae)
        {
            var result = _curriculumVitaeService.Delete(curriculumVitae);
            if (result.Success)
            {
                return Ok(result.Message);
            }

            return BadRequest(result.Message);
        }
        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _curriculumVitaeService.GetById(id);
            if (result.Success)
            {
                return Ok(result.Data);
            }

            return BadRequest(result.Message);
        }
    }
}