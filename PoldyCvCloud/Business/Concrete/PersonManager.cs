using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Concrete
{
   public class PersonManager:IPersonService
    {
        public IResult Add(Person person)
        {
            throw new NotImplementedException();
        }

        public IResult Update(Person person)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(Person person)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Person>> GetList()
        {
            throw new NotImplementedException();
        }
    }
}
