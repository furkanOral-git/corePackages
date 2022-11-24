using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Domain.Entities
{
    public interface IAggregateRoot<TEntity> where TEntity : Entity, new()
    {
        
    }
}