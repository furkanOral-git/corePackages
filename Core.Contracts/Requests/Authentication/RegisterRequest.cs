using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Contracts.Requests.Authentication
{
    public record RegisterRequest(string password,string userName,string email);
    
}