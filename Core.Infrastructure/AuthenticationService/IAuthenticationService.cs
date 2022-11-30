using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Infrastructure.AuthenticationService
{
    public interface IAuthenticationService
    {
        public bool IsValid(string userName, string password);
        public void Login(string userName, string password);
        public void Register(string userName, string password, string email);
        
    }
}