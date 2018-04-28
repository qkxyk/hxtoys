using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using HX.Toys.Model;

namespace HX.Toys.EFSource
{
    public class SchoolContext : DbContext
    {
        public SchoolContext()
         : base("name=SchoolContext")
        {
        }

        public virtual DbSet<Student> Student { get; set; }
        public virtual DbSet<Book> Book { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new StudentMap());
            modelBuilder.Configurations.Add(new BookMap());
            base.OnModelCreating(modelBuilder);
        }
    }
}
