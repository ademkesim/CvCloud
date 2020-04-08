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
    public class ApplyController : ControllerBase
    {
        private IApplyService _applyService;
        public ApplyController(IApplyService applyService)
        {
            _applyService = applyService;
        }
        [HttpGet("getall")]
        public IActionResult GetList()
        {
            var result = _applyService.GetList();
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);
        }
        [HttpGet("getbydepartment")]
        public IActionResult GetByDepartment(int getbydepartmentId)
        {
            var result = _applyService.GetByDepartment(getbydepartmentId);
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);
        }
        [HttpGet("getbytitle")]
        public IActionResult GetByTitle(int getbytitleId)
        {
            var result = _applyService.GetByTitle(getbytitleId);
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);
        }
        [HttpPost("add")]
        public IActionResult Add(Apply apply)
        {
            var result = _applyService.Add(apply);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);
        }
        [HttpPost("delete")]
        public IActionResult Delete(Apply apply)
        {
            var result = _applyService.Delete(apply);
            if (result.Success)
            {
                return Ok(result.Message);
            }

            return BadRequest(result.Message);
        }
        [HttpPost("update")]
        public IActionResult Update(Apply apply)
        {
            var result = _applyService.Update(apply);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);
        }
    }
}
