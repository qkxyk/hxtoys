using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HX.Toys.Model
{
    public class Student : IEntity<int>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public string Classroom { get; set; }
    }
}
