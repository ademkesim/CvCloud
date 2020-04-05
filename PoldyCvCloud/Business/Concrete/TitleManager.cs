using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class TitleManager : ITitleService
    {
        public IResult Add(Title title)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(Title title)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Title>> GetByDepartment(int getbydepartmentId)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Title>> GetList()
        {
            throw new NotImplementedException();
        }

        public IResult Update(Title title)
        {
            throw new NotImplementedException();
        }
    }
}
