using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using ItsApp.Authorization;

namespace ItsApp
{
    [DependsOn(
        typeof(ItsAppCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class ItsAppApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<ItsAppAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(ItsAppApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
