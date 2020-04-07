using Business.Abstract;
using Business.Concrete;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using Autofac;
using Core.Security.Jwt;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
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
            builder.RegisterType<AutoManager>().As<IAutoService>();
            builder.RegisterType<JwtHelper>().As<ITokenHelper>();
            builder.RegisterType<EfPersonDal>().As<IPersonDal>();
            builder.RegisterType<EfApplyDal>().As<IApplyDal>();
            builder.RegisterType<EfCurricilumVitaeDal>().As<ICurriculumVitaeDal>();
            builder.RegisterType<EfDepartmentDal>().As<IDepartmentDal>();
            builder.RegisterType<EfJobAdvertisementDal>().As<IJobAdvertisementDal>();
            builder.RegisterType<EfTitleDal>().As<ITitleDal>();




        }
    }
}
