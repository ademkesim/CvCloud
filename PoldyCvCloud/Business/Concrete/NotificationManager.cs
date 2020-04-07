using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using Business.Constans;
using Core.Entities.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class NotificationManager:INotificationService
    {
        private INotificationDal _notificationDal;
       

        public NotificationManager(INotificationDal notificationDal)
        {
            _notificationDal = notificationDal;
          
        }

        public IResult Add(Notification notification)
        {
            _notificationDal.Add(notification);
            return new SuccessResult(Messages.NotificationAdded);
        }

        public IResult Update(Notification notification)
        {
            _notificationDal.Update(notification);
            return new SuccessResult(Messages.NotificationUpdated);
        }

        public IResult Delete(Notification notification)
        {
            _notificationDal.Update(notification);
            return new SuccessResult(Messages.NotificationDeleted);
        }
    }
}
