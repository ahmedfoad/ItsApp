using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace ItsApp.Controllers
{
    public abstract class ItsAppControllerBase: AbpController
    {
        protected ItsAppControllerBase()
        {
            LocalizationSourceName = ItsAppConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
