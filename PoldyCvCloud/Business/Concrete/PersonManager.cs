using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using Business.Constans;
using Core.Entities.Concrte;
using Core.Utilities.Results;
using DataAccess.Abstract;

namespace Business.Concrete
{
   public class PersonManager:IPersonService
   {
        private IPersonDal _personDal;
        private IPersonService _personService;

        public PersonManager(IPersonDal personDal, IPersonService personService)
        {
            _personDal = personDal;
            _personService = personService;

        }

        public IResult Add(Person person)
       {
           _personDal.Add(person);
           return new SuccessResult(Messages.PersonAdded);
       }

        public IResult Update(Person person)
        {
            _personDal.Update(person);
            return new SuccessResult(Messages.PersonUpdated);
        }

        public IResult Delete(Person person)
        {
            _personDal.Delete(person);
            return new SuccessResult(Messages.PersonDeleted);
        }


        public IDataResult<List<Person>> GetList()
        {
            return new SuccessDataResult<List<Person>>(_personDal.GetList());
        }

        public Person GetByMail(string mail)
        {
            return _personDal.Get(u => u.Mail == mail);
        }

        public IResult UserExists(string email)
        {
            if (_personService.GetByMail(email) != null)
            {
                return new ErrorResult(Messages.alreadyUserExists);
            }
            return new SuccessResult();
        }
    }
}
