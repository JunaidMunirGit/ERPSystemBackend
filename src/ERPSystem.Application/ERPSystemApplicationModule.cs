using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using ERPSystem.Authorization;

namespace ERPSystem
{
    [DependsOn(
        typeof(ERPSystemCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class ERPSystemApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<ERPSystemAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(ERPSystemApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
