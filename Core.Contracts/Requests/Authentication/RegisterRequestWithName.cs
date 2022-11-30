using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Contracts.Requests.Authentication
{
    public record RegisterRequestWithName(string firstName, string lastName, string password, string email);
   
}