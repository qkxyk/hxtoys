using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAPI.Model
{
    public class Role : IAggregateRoot<string>
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public bool IsAdmin { get; set; }
        public override string ToString()
        {
            return Id + "->" + Name + "：" + (IsAdmin ? "管理员" : "非管理员");
        }
    }
}
