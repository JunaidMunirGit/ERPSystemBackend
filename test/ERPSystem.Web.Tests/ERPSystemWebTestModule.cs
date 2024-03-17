using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using ERPSystem.EntityFrameworkCore;
using ERPSystem.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace ERPSystem.Web.Tests
{
    [DependsOn(
        typeof(ERPSystemWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class ERPSystemWebTestModule : AbpModule
    {
        public ERPSystemWebTestModule(ERPSystemEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(ERPSystemWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(ERPSystemWebMvcModule).Assembly);
        }
    }
}