using System;
using System.Collections.Generic;
using System.Text;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IDepartmentService
    {
        IResult Add(Department department);

        IResult Update(Department department);

        IResult Delete(Department department);

        IDataResult<List<Department>> GetList();

    }
}
