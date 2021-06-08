using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASPBasic.Models;

namespace ASPBasic.Interface
{
    public interface IRepository
    {
        HashSet<Book> Books { get; set; }
        Book Get(int id);
        bool Delete(int id);
        Book Create();
        bool Add(Book book);
        bool Update(Book book);
    }
}
