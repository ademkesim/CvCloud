using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using Business.Abstract;
using Business.Constans;
using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Concrete
{
   public class DepartmentManager:IDepartmentService
   {
       private IDepartmentDal _departmentDal;

       public DepartmentManager(IDepartmentDal departmentDal)
       {
           _departmentDal = departmentDal;
       }

       public IResult Add(Department department)
       {
           _departmentDal.Add(department);
           return SuccessResult(Messages.DepartmentAdded);
       }

        public IResult Update(Department department)
        {
            _departmentDal.Update(department);
            return SuccessResult(Messages.DepartmentUpdated);
        }

        public IResult Delete(Department department)
        {
            _departmentDal.Delete(department);
            return SuccesResult(Messages.DepartmentDeleted);
        }

        public IDataResult<List<Department>> GetList()
        {
            return SuccessDataResult <List<Department>>(_departmentDal.GetList());
        }
    }
}
