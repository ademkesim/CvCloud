using Business.Abstract;
using Business.Concrete;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using Autofac;
using Module = Autofac.Module;

namespace Business.DependencyResolvers.Autofac
{
   public class AutofacBusinessModule:Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ApplyManager>().As<IApplyService>();
            builder.RegisterType<CurriculumVitaeManager>().As<ICurriculumVitaeService>();
            builder.RegisterType<DepartmentManager>().As<IDepartmentService>();
            builder.RegisterType<JobAdvertisementManager>().As<IJobAdvertisementService>();
            builder.RegisterType<PersonManager>().As<IPersonService>();
            builder.RegisterType<TitleManager>().As<ITitleService>();

        }
    }
}
