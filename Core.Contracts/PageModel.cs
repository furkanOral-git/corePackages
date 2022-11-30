using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Contracts
{
    public class PageModel<T> : IPaginate<T> where T : class, new()
    {
        public T[]? Items { get; private set; }
        public int CurrentPage { get; init; }
        public int PageSize { get; init; }
        public int TotalPageCount { get; private set; }
        public int TotalItemCount { get; private set; }
        public bool HasPrevious { get; private set; }
        public bool HasNext { get; private set; }

        public PageModel(int currentPage, int pageSize, T[] data)
        {
            CurrentPage = currentPage;
            PageSize = pageSize;
            Items = Paginate(data);
        }

        public T[] Paginate(T[] data)
        {
            TotalItemCount = data.Length;
            if (TotalItemCount % PageSize > 0) TotalPageCount = (TotalItemCount / PageSize) + 1;
            if (TotalItemCount % PageSize == 0) TotalPageCount = TotalItemCount / PageSize;
            if (TotalItemCount % PageSize < 0)
            {
                TotalPageCount = 1;
                HasPrevious = false;
                HasNext = false;
                return data;
            }
            
            if (CurrentPage == TotalPageCount)
            {
                HasPrevious = true;
                HasNext = false;
            }

            if (CurrentPage == 1)
            {
                HasPrevious = false;
                HasNext = true;
            }

            if (CurrentPage < TotalPageCount && CurrentPage > 1)
            {
                HasPrevious = true;
                HasNext = true;
            }

            

            int initialIndex = (CurrentPage - 1) * PageSize;
            int lastIndex = TotalItemCount - 1;
            int pageItemCount = ((lastIndex - initialIndex + 1) < PageSize) ? lastIndex - initialIndex + 1 : PageSize;
            var paginatedArray = new T[pageItemCount];

            for (var i = 0; i < pageItemCount; i++)
            {
                paginatedArray[i] = data[initialIndex];
                initialIndex++;
            }
            return paginatedArray;

        }
    }
}