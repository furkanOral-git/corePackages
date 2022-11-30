using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Contracts.Reponses
{
    public record SuccessAuthenticationResponse(int id, string userName, string email, string token);
    
}