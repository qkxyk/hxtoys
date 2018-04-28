using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HX.Toys.Model;
using HX.Toys.EFSource;

namespace HX.Toys.Repository
{
    public class BookEFRepository : EFRepositoryBase<SchoolContext, Book, Guid>, IBookRepository
    {
        public override bool Update(Book model)
        {
            try
            {
                //RemoveHoldingEntityInContext(model);
                using (var db= new SchoolContext())
                {
                    db.Book.Attach(model);
                    db.Entry(model).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                }
                //this.GetSet().Attach(model);
                //m_dbContext.Entry(model).CurrentValues.SetValues(model);
                ////this.m_dbContext.Entry(model).State = EntityState.Modified;
                //this.m_dbContext.SaveChanges();

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
