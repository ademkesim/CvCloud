using System;
using System.Collections.Generic;
using System.Text;
using Core.Utilities.Results;
using Entities.Concrete;
using Entities.Dtos;

namespace Business.Abstract
{
    public interface IAuthService
    {
        IDataResult<Person> Register(UserForRegisterDto userForRegisterDto, string password);
        IDataResult<Person> Login(UserForLoginDto userForLoginDto);
        IResult UserExists(string email);
    }
}
