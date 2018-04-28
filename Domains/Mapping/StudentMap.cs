using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;

namespace HX.Toys.Model
{
    public class StudentMap : EntityTypeConfiguration<Student>
    {
        public StudentMap()
        {
            ToTable("Student").HasKey(a => a.Id);
            Property(a => a.Name).HasMaxLength(25).IsRequired();
        }
    }
}
