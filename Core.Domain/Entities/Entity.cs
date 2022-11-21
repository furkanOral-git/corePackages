using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Domain.Entities
{
    public abstract class Entity : IEntity
    {
        public int Id { get; set; }
    }
}