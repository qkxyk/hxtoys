using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAPI.Model
{
    public class User : IAggregateRoot<string>
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Description { get; set; }
        public int Sex { get; set; } = 0;
        public override string ToString()
        {
            return Id + "->" + Name;
        }
    }
}
