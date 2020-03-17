using Abp.Web.Mvc.Views;

namespace MetroDevABM.Web.Views
{
    public abstract class MetroDevABMWebViewPageBase : MetroDevABMWebViewPageBase<dynamic>
    {

    }

    public abstract class MetroDevABMWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected MetroDevABMWebViewPageBase()
        {
            LocalizationSourceName = MetroDevABMConsts.LocalizationSourceName;
        }
    }
}