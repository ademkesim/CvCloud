using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using Business.Constans;
using Core.Hashing;
using Core.Security.Jwt;
using Core.Utilities.Results;
using Entities.Concrete;
using Entities.Dtos;

namespace Business.Concrete
{
  public class AutoManager:IAutoService
    {
        private IPersonService _personService;
        private ITokenHelper _tokenHelper;

        public AutoManager(IPersonService personService, ITokenHelper tokenHelper)
        {
            _personService = personService;
            _tokenHelper = tokenHelper;
        }

        public IDataResult<Person> Register(UserForRegisterDto userForRegisterDto, string password)
        {
            byte[] passwordHash, passwordSalt;
            HashingHelper.CreatePasswordHash(password, out passwordHash, out passwordSalt);
            var person = new Person
            {
                FirstName = userForRegisterDto.FirstName,
                LastName = userForRegisterDto.LastName,
                Mail = userForRegisterDto.Mail,
                PasswordHash = passwordHash,
                PasswordSalt = passwordSalt,
                Rank = userForRegisterDto.Rank,
                Status = true
            };
            _personService.Add(person);
            return new SuccessDataResult<Person>(person, Messages.userRegistered);
        }

        public IDataResult<Person> Login(UserForLoginDto userForLoginDto)
        {
            var userToCheck = _personService.GetByMail(userForLoginDto.Email);
            if (userToCheck == null)
            {
                return new ErrorDataResult<Person>(Messages.UserNotFound);
            }

            if (HashingHelper.VeryfPasswordHash(userForLoginDto.Password, userToCheck.PasswordHash,
                userToCheck.PasswordSalt))
            {
                return new ErrorDataResult<Person>(Messages.PasswordEror);

            }

            return new SuccessDataResult<Person>(userToCheck, Messages.SuccesfulLogin);


        }

        public IResult UserExists(string email)
        {
            if (_personService.GetByMail(email) != null)
            {
                return new ErrorResult(Messages.alreadyUserExists);
            }
            return new SuccessResult();
        }

        public IDataResult<AccessToken> CreateAccessToken(Person person)
        {
            var accessToken = _tokenHelper.CreateToken(person);
            return new SuccessDataResult<AccessToken>(accessToken, Messages.AccessTokenCreated);
        }
    }
}
