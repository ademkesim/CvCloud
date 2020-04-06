using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
  public  interface IJobAdvertisementService
  {
      IResult Add(JobAdvertisement jobadvertisement);

      IResult Update(JobAdvertisement jobadvertisement);

      IResult Delete(JobAdvertisement jobadvertisement);

      IDataResult<List<JobAdvertisement>> GetList();

      IDataResult<List<JobAdvertisement>> GetByDepartment(int getbydepartmentId);

      IDataResult<List<JobAdvertisement>> GetByTitle(int getbytitleId);
    }
}
