using Abp.Application.Services;

namespace MetroDevABM
{
    /// <summary>
    /// Derive your application services from this class.
    /// </summary>
    public abstract class MetroDevABMAppServiceBase : ApplicationService
    {
        protected MetroDevABMAppServiceBase()
        {
            LocalizationSourceName = MetroDevABMConsts.LocalizationSourceName;
        }
    }
}