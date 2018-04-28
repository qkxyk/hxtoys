using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HX.Toys.Repository
{
    public static class RepositoryFactory
    {

        public static TRepository Create<TRepository>(ContextTypes ctype) where TRepository : class
        {
            switch (ctype)
            {
                case ContextTypes.EntityFramework:
                    var a = Activator.CreateInstance<TRepository>();
                    if (a != null)
                    {
                        return a;
                    }
                    //if (typeof(TRepository) == typeof(IStudentRepository))
                    //{
                    //    return new StudentEFRepository() as TRepository;
                    //}
                    return null;
                case ContextTypes.XMLSource:
                    if (typeof(TRepository) == typeof(IStudentRepository))
                    {
                        //return new StudentXMLRepository() as TRepository;
                    }
                    return null;
                default:
                    return null;
            }
        }
    }
}
