using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;

namespace HX.Toys.Model
{
    public class BookMap : EntityTypeConfiguration<Book>
    {
        public BookMap()
        {
            ToTable("Book").HasKey(a => a.Id);
        }
    }
}
