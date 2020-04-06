using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Concrete
{
   public class JobAdvertisementManager:IJobAdvertisementService
   {
       private IJobAdvertisementDal  _jobAdvertisementDal;

       public JobAdvertisementManager(IJobAdvertisementDal jobAdvertisementDal)
       {
           _jobAdvertisementDal = jobAdvertisementDal;
       }

       public IResult Add(JobAdvertisement jobadvertisement)
       {
          _jobAdvertisementDal.Add(jobadvertisement);
          return SuccesResult(Message.JobAdvertisementAdded);
       }

       public IResult Update(JobAdvertisement jobadvertisement)
       {
           _jobAdvertisementDal.Update(jobadvertisement);
           return new  SuccessResult(Message.JobAdvertisementUpdated);
       }

       public IResult Delete(JobAdvertisement jobadvertisement)
       {
           _jobAdvertisementDal.Delete(jobadvertisement);
           return new SuccesResult(Message.JobAdvertisementDeleted);
       }

       public IDataResult<List<JobAdvertisement>> GetList()
       {
           return new SuccessDataResult<List<JobAdvertisement>>(_jobAdvertisementDal.GetList());
       }

       public IDataResult<List<JobAdvertisement>> GetByDepartment(int getbydepartmentId)
       {
           return new SuccessDataResult<List<JobAdvertisement>>(_jobAdvertisementDal.Get(p=>p.DepartmentId==getbydepartmentId));
       }

       public IDataResult<List<JobAdvertisement>> GetByTitle(int getbytitleId)
       {
           return new SuccessDataResult<List<JobAdvertisement>>(_jobAdvertisementDal.Get(p => p.TitleId == getbytitleId));
        }
   }
}
}
