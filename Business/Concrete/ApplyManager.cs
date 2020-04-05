using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;

namespace Business.Concrete
{
public class ApplyManager:IApplyService
    {
        public IDataResult<List<Apply>> GetList()
        {
            throw new NotImplementedException();
        }

        public IResult Add(Apply apply)
        {
            throw new NotImplementedException();
        }

        public IResult Update(Apply apply)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(Apply apply)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Apply>> GetByDepartment(int getbydepartmentId)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Apply>> GetByTitle(int getbytitle)
        {
            throw new NotImplementedException();
        }
    }
}
