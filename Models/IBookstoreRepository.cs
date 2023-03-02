using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission09_chasejr.Models
{
    public interface IBookstoreRepository
    {       
        IQueryable<Book> Books { get; }
    }
}
