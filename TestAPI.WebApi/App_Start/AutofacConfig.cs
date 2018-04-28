using Autofac;
using Autofac.Integration.Mvc;
using Autofac.Integration.WebApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace TestAPI.WebApi
{
    public class AutofacConfig
    {
        public static void Register()
        {
            //第一步： 构造一个AutoFac的builder容器
            var builder = new ContainerBuilder();
            SetupResolveRules(builder);
            //2.1 从当前运行的bin目录下加载FB.CMS.MvcSite.dll程序集  

           // builder.RegisterApiControllers(Assembly.GetExecutingAssembly()).PropertiesAutowired();
            Assembly controllerAss = Assembly.Load("TestAPI.WebApi");

            //2.2 告诉AutoFac控制器工厂，控制器的创建从controllerAss中查找（注意：RegisterControllers()方法是一个可变参数，如果你的控制器类的创建需要去多个程序集中查找的话，那么我们就再用Assembly controllerBss=Assembly.Load("需要的程序集名")加载需要的程序集，然后与controllerAss组成数组，然后将这个数组传递到RegisterControllers()方法中）  
         
            builder.RegisterApiControllers(controllerAss);
          

            var container = builder.Build();
            HttpConfiguration config = GlobalConfiguration.Configuration;
            config.DependencyResolver = new AutofacWebApiDependencyResolver(container);
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
            //DependencyResolver.SetResolver(new AutofacWebApiDependencyResolver(container));
        }
        private static void SetupResolveRules(ContainerBuilder builder)
        {
            Assembly repositoryAss = Assembly.Load("TestAPI.Repository");
            //3.2 反射扫描这个FB.CMS.Repository.dll程序集中所有的类，得到这个程序集中所有类的集合。  
            Type[] rtypes = repositoryAss.GetTypes();
            //3.3 告诉AutoFac容器，创建rtypes这个集合中所有类的对象实例  
            builder.RegisterTypes(rtypes)
                .AsImplementedInterfaces(); //指明创建的rtypes这个集合中所有类的对象实例，以其接口的形式保存  


            //3.4 加载业务逻辑层FB.CMS.Services这个程序集。  
            Assembly servicesAss = Assembly.Load("TestAPI.Service");
            //3.5 反射扫描这个FB.CMS.Services.dll程序集中所有的类，得到这个程序集中所有类的集合。  
            Type[] stypes = servicesAss.GetTypes();
            //3.6 告诉AutoFac容器，创建stypes这个集合中所有类的对象实例  
            builder.RegisterTypes(stypes)
                .AsImplementedInterfaces(); //指明创建的stypes这个集合中所有类的对象实例，以其接口的形式保存         
        }
    }
}