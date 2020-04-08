using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities.Concrte;

namespace Core.Security.Jwt
{
    public interface ITokenHelper
    {
        AccessToken CreateToken(Person person);
    }
}

