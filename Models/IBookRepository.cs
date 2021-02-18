using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JustisBookstore.Models
{
    public interface IBookRepository
    {
        IQueryable<Book> Books { get; }//Makes IQueryable of Book for using with Database
    }
}
