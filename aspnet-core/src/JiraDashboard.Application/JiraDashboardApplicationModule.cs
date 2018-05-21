using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using JiraDashboard.Authorization;

namespace JiraDashboard
{
    [DependsOn(
        typeof(JiraDashboardCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class JiraDashboardApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<JiraDashboardAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(JiraDashboardApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddProfiles(thisAssembly)
            );
        }
    }
}
