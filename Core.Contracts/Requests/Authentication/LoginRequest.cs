using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Contracts.Requests.Authentication
{
    public record LoginRequest(string password,string userName);
   
}