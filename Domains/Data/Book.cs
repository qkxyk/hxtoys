using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HX.Toys.Model
{
    public class Book : IEntity<Guid>
    {
        public Guid Id { get; set; }
        public string BookName { get; set; }
        public DateTime AddTime { get; set; }
    }
}
