using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace JiraDashboard.Controllers
{
    public abstract class JiraDashboardControllerBase: AbpController
    {
        protected JiraDashboardControllerBase()
        {
            LocalizationSourceName = JiraDashboardConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
