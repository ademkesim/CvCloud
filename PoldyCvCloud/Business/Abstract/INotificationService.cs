using System;
using System.Collections.Generic;
using System.Text;
using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
   public interface INotificationService
   {
       IResult Add(Notification notification);
       IResult Update(Notification notification);
       IResult Delete(Notification notification);
   }
}
