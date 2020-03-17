using System.Reflection;
using Abp.Application.Services;
using Abp.Configuration.Startup;
using Abp.Modules;
using Abp.WebApi;

namespace MetroDevABM
{
    [DependsOn(typeof(AbpWebApiModule), typeof(MetroDevABMApplicationModule))]
    public class MetroDevABMWebApiModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());

            Configuration.Modules.AbpWebApi().DynamicApiControllerBuilder
                .ForAll<IApplicationService>(typeof(MetroDevABMApplicationModule).Assembly, "app")
                .Build();
        }
    }
}
