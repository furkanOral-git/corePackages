using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Contracts.Reponses
{
    public record SuccessAuthenticationResponseWithName<TId>(TId id, string firstName, string lastName, string email, string token);

}