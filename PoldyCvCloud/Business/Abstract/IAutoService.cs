using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities.Concrte;
using Core.Security.Jwt;
using Core.Utilities.Results;
using Entities.Concrete;
using Entities.Dtos;

namespace Business.Abstract
{
  public interface IAutoService
    {
        IDataResult<Person> Register(UserForRegisterDto userForRegisterDto, string password);
        IDataResult<Person> Login(UserForLoginDto userForLoginDto);
        IResult UserExists(string email);
        IDataResult<AccessToken> CreateAccessToken(Person person);
    }
}
