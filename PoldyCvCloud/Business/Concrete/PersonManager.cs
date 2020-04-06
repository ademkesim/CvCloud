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
       private IPersonDal _personDal;

       public PersonManager(IPersonDal personDal)
       {
           _personDal = personDal;
       }

       public IResult Add(Person person)
       {
           _personDal.Add(person);
           return new SuccessResult(Message.personAdded);
       }

        public IResult Update(Person person)
        {
            _personDal.Update(person);
            return new SuccesResult(Message.personUpdated);
        }

        public IResult Delete(Person person)
        {
            _personDal.Delete(person);
            return new SuccessResult(Message.personDeleted);
        }


        public IDataResult<List<Person>> GetList()
        {
            return new SuccessDataResult<List<Person>>(_personDal.GetList());
        }

    }
}
