using HX.Toys.EFSource;
using HX.Toys.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HX.Toys.Repository
{
    public class StudentEFRepository : EFRepositoryBase<SchoolContext, Student, int>, IStudentRepository
    {
        public override bool Update(Student model)
        {
            try
            {
                //RemoveHoldingEntityInContext(model);
                using (var db = new SchoolContext())
                {
                    #region 第一种
                    /*
                    Student s = new Student() { Id = model.Id };
                    var ss = db.Student.Attach(s);
                    if (model.Classroom == null)
                    {

                    }
                    ss.Name = model.Name;
                    ss.SurName = model.SurName;
                    */
                    #endregion
                    var s = db.Student.Where(a => a.Id == model.Id).FirstOrDefault();
                    if (model.Name != null)
                    {
                        s.Name = model.Name;
                    }
                    if (model.SurName != null)
                    {
                        s.SurName = model.SurName;
                    }
                    if (model.Classroom != null)
                    {
                        s.Classroom = model.Classroom;
                    }
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
