using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Contracts
{
    public interface IPaginate<TEntity> where TEntity : class, new()
    {
        public TEntity[] Paginate(TEntity[] data);
    }
}