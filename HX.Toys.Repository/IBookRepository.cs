using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HX.Toys.Model;

namespace HX.Toys.Repository
{
    public interface IBookRepository : IRepository<Book, Guid>
    {
    }
}
