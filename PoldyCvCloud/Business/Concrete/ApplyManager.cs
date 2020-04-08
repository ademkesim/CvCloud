using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using Business.Constans;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
public class ApplyManager:IApplyService
{
    private IApplyDal _applyDal;
    private INotificationDal _notificationDal;

    public ApplyManager(IApplyDal applyDal, INotificationDal notificationDal)
    {
        _applyDal = applyDal;
        _notificationDal = notificationDal;
    }

    public IDataResult<List<Apply>> GetList()
        {
            return new SuccessDataResult<List<Apply>>(_applyDal.GetList());
        }

        public IResult Add(Apply apply)
        {
            _applyDal.Add(apply);
            return new SuccessResult(Messages.ApplyAdded);
        }

        public IResult Update(Apply apply)
        {
            _applyDal.Update(apply);
            return new SuccessResult(Messages.ApplyUpdated);
        }

        public IResult Delete(Apply apply)
        {
            _applyDal.Delete(apply);
            return new SuccessResult(Messages.ApplyDeleted);
        }

        public IDataResult<List<Apply>> GetByDepartment(int getbydepartmentId)

        {
            return new SuccessDataResult<List<Apply>>(_applyDal.GetList(p => p.DepartmentId == getbydepartmentId));
        }

        public IDataResult<List<Apply>> GetByTitle(int getbytitleId)
        {

            return new SuccessDataResult<List<Apply>>(_applyDal.GetList(p => p.TitleId == getbytitleId));
        }

        public void Conformation()
        {
            bool onay=true;
            if (onay)
            {
                var result = _notificationDal.Get(p => p.NotificationId == 1);
                var message = result.Message;
                


            }
            else
            {
                var result = _notificationDal.Get(p => p.NotificationId == 2);
                var message = result.Message;
              
            }


        }
    }
}
