using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HX.Toys.Repository;
using HX.Toys.Model;
using System.Reflection;
using System.Threading;

namespace HX.Toys.WinTest
{
    public partial class FrmTest : Form
    {
        public FrmTest()
        {
            InitializeComponent();
        }
        IRepository<Student, int> rep = new Repository.StudentEFRepository();
        private void FrmTest_Load(object sender, EventArgs e)
        {
            Book book = new Book() { Id = Guid.NewGuid(), AddTime = DateTime.Now, BookName = "aaa" };
            TT<Book>.GetPropery(book);
            IFruit f = FruitFactory<Apple>.CreateFriut();
            f.output();
        }



        private void btnCreateStu_Click(object sender, EventArgs e)
        {
            Student stu = new Student() { Name = "张三", SurName = "test", Classroom = "abc" };
            //IRepository<Student, int> rep = new Repository.StudentEFRepository();
            int i = rep.Insert(stu);
            MessageBox.Show(i.ToString());
        }

        private void btnGetStu_Click(object sender, EventArgs e)
        {

            Student stu = rep.Find(a => a.Name == "张三").FirstOrDefault();
            MessageBox.Show(stu.SurName);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            IRepository<Student, int> re = new Repository.StudentEFRepository();
            Student stu = new Student() { Id = 1, Name = "李四", SurName = "张三之" };
            stu.SurName += new Random().Next(2, 9).ToString();
            bool bRet = re.Update(stu);
            MessageBox.Show(bRet.ToString());

        }

        private void btnAddOrUpdate_Click(object sender, EventArgs e)
        {
            IRepository<Student, int> re = RepositoryFactory.Create<StudentEFRepository>(ContextTypes.EntityFramework);
            Student stu = new Student() { Name = txtUser.Text };
            var s = re.Find(a => a.Name == stu.Name).FirstOrDefault();
            if (s == null)
            {
                MessageBox.Show(re.Insert(stu).ToString());
            }
            else
            {
                s.SurName = "张无忌";
                MessageBox.Show(re.Update(s).ToString());
            }
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            RepositoryFactory.Create<StudentEFRepository>(ContextTypes.EntityFramework);
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            IRepository<Book, Guid> re = RepositoryFactory.Create<BookEFRepository>(ContextTypes.EntityFramework);
            var a = re.Insert(new Book() { Id = Guid.NewGuid(), BookName = txtUser.Text, AddTime = DateTime.Now });
            MessageBox.Show(a.ToString("N"));
        }

        private async void btnAsync_Click(object sender, EventArgs e)
        {
            Output();
            Console.WriteLine("forth");
            //  Console.WriteLine(Second());
            await Second();
            Console.WriteLine("fifth");
        }
        private async void Output()
        {
            Console.WriteLine("First");
            await Second();
            Console.WriteLine("Third");
        }
        public async Task Second()
        {
            Console.WriteLine("Second");
            Console.WriteLine("abc");
            await Task.Delay(TimeSpan.FromSeconds(1));
            Console.WriteLine("*****");
                    
        }
    }
    public static class TT<TEntity>
    {
        public static void GetPropery(TEntity t)
        {
            var type = typeof(TEntity);
            PropertyInfo[] propertyInfo = type.GetProperties();//.GetProperty("Property1"); //获取指定名称的属性
            foreach (var item in propertyInfo)
            {

            }
            var tt = t.GetType().GetProperties();
            foreach (var item in tt)
            {

            }
        }
    }
}
