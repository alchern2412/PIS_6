using DictionaryInterface;
using JsonRepo;
using Ninject.Modules;
using Ninject.Web.Common;
using SqlRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace lab6.Util
{
    public class NinjectRegistrations : NinjectModule
    {
        public override void Load()
        {
            Bind<IPhoneDictionary>().To<JsonRepository>().InTransientScope(); // .InTransientScope() по умолчанию 
            //Bind<IPhoneDictionary>().To<SqlRepository>();
            //Bind<IPhoneDictionary>().To<SqlRepository>().InThreadScope();
            //Bind<IPhoneDictionary>().To<SqlRepository>().InRequestScope(); // новый экземпляр на каждый запрос
        }
    }
}