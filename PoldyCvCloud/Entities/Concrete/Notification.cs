using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Notification:IEntity
    {
        public int NotificationId { get; set; }
        public int PersonId { get; set; }
        public string Message { get; set; }
    }
}
