using System;
using System.Collections.Generic;
using System.Text;
using Entities.Concrete;

namespace Core.Security.Jwt
{
    public interface ITokenHelper
    {
        AccessToken CreateToken(Person person);
    }
}

