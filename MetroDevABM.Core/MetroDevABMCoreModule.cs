using System.Reflection;
using Abp.Modules;

namespace MetroDevABM
{
    public class MetroDevABMCoreModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
