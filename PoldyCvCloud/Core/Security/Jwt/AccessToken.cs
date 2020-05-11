using System;
using System.Collections.Generic;
using System.Text;
using Entities.Concrete;

namespace Core.Security.Jwt
{
    public class AccessToken
    {
        public string Token { get; set; }
        public DateTime Expiration { get; set; }
        public Person Person { get; set; }
    }
}
