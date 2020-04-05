using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;

namespace Business.Concrete
{
   public class DepartmentManager:IDepartmentService
    {
        public IResult Add(Department department)
        {
            throw new NotImplementedException();
        }

        public IResult Update(Department department)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(Department department)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Department>> GetList()
        {
            throw new NotImplementedException();
        }
    }
}
