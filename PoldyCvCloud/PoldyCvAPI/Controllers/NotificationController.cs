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
    public class NotificationController:ControllerBase
    {
        private INotificationService _notificationService;
        public NotificationController(INotificationService notificationService)
        {
            _notificationService = notificationService;
        }
        [HttpPost("add")]
        public IActionResult Add(Notification notification)
        {
            var result = _notificationService.Add(notification);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);
        }
        [HttpPost("update")]
        public IActionResult Update(Notification notification)
        {
            var result = _notificationService.Update(notification);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);
        }
        [HttpPost("delete")]
        public IActionResult Delete(Notification notification)
        {
            var result = _notificationService.Delete(notification);
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);
        }
    }
}
