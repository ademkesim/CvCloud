using System;
using System.Collections.Generic;
using System.Text;
using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
   public interface IPersonService
   {
       IResult Add(Person person);
        IResult Update(Person person);
        IResult Delete(Person person);
        IDataResult<List<Person>> GetList();
        Person GetByMail(string email);
    }
}
