using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace TestFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            Expression<Func<int, int, int>> expr = (x, y) => x + y;
            Console.WriteLine(expr.Compile()(3, 5));
            ParameterExpression pa = Expression.Parameter(typeof(int), "x");
            ParameterExpression pb = Expression.Parameter(typeof(int), "y");
            BinaryExpression bexp = Expression.Add(pa, pb);
            var lab = Expression.Lambda<Func<int, int, int>>(bexp, new ParameterExpression[] { pa, pb });
            Console.WriteLine(lab.Compile()(4, 6));
            Console.ReadKey();
        }
    }

    public static class Operate<T>
    {
        private static readonly Func<T, T, T> add;
        public static T Add(T x, T y)
        {
            return add(x, y);
        }
        static Operate()
        {
            var x = Expression.Parameter(typeof(T), "x");
            var y = Expression.Parameter(typeof(T), "y");
            var body = Expression.Add(x, y);
            add = Expression.Lambda<Func<T, T, T>>(body, new ParameterExpression[] { x, y }).Compile();
        }
    }
}
