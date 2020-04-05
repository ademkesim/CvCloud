using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;

namespace Business.Concrete
{
    public class JobAdvertisementManager : IJobAdvertisementService
    {
        public IResult Add(JobAdvertisement jobadvertisement)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(JobAdvertisement jobadvertisement)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<JobAdvertisement>> GetByDepartment(int getbydepartmentId)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<JobAdvertisement>> GetByTitle(int getbytitleId)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<JobAdvertisement>> GetList()
        {
            throw new NotImplementedException();
        }

        public IResult Update(JobAdvertisement jobadvertisement)
        {
            throw new NotImplementedException();
        }
    }
}
