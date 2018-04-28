using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace HX.Toys.WinTest
{
    class Test
    {
    }
    public interface IFruit
    {
        void output();

    }
    public class Apple : IFruit
    {
        public void output()
        {
            Console.WriteLine("This is an apple");
        }
    }
    public class Pear : IFruit
    {
        public void output()
        {
            Console.WriteLine("This is a pear");
        }
    }

    public static class FruitFactory<TFruit> where TFruit : class, IFruit
    {
        public static IFruit CreateFriut()
        {
            //var a = Activator.CreateInstance<TFruit>();
            //return a;
            var ass = Assembly.GetExecutingAssembly();
            var types = ass.GetTypes();//.Where(b=>b.GetType()==typeof(TFruit)).ToList();
            IFruit aa = null;
            var types1 = ass.GetTypes().Where(type => type.BaseType != null && type.BaseType.IsGenericType && type.BaseType.GetGenericTypeDefinition() == typeof(TFruit));
            foreach (var item in types)
            {               
                if (item == typeof(TFruit))
                {
                    aa = Activator.CreateInstance(item) as IFruit;
                }
            }
            return aa;
        }
    }
}
