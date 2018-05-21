using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using JiraDashboard.Configuration;

namespace JiraDashboard.Web.Host.Startup
{
    [DependsOn(
       typeof(JiraDashboardWebCoreModule))]
    public class JiraDashboardWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public JiraDashboardWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(JiraDashboardWebHostModule).GetAssembly());
        }
    }
}
