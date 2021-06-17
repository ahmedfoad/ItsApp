using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using ItsApp.EntityFrameworkCore;
using ItsApp.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace ItsApp.Web.Tests
{
    [DependsOn(
        typeof(ItsAppWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class ItsAppWebTestModule : AbpModule
    {
        public ItsAppWebTestModule(ItsAppEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(ItsAppWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(ItsAppWebMvcModule).Assembly);
        }
    }
}