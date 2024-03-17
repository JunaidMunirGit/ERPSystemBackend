using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace ERPSystem.Controllers
{
    public abstract class ERPSystemControllerBase: AbpController
    {
        protected ERPSystemControllerBase()
        {
            LocalizationSourceName = ERPSystemConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
