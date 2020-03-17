using Abp.Web.Mvc.Controllers;

namespace MetroDevABM.Web.Controllers
{
    /// <summary>
    /// Derive all Controllers from this class.
    /// </summary>
    public abstract class MetroDevABMControllerBase : AbpController
    {
        protected MetroDevABMControllerBase()
        {
            LocalizationSourceName = MetroDevABMConsts.LocalizationSourceName;
        }
    }
}