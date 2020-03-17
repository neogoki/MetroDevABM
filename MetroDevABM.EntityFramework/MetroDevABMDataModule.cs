using System.Data.Entity;
using System.Reflection;
using Abp.EntityFramework;
using Abp.Modules;
using MetroDevABM.EntityFramework;

namespace MetroDevABM
{
    [DependsOn(typeof(AbpEntityFrameworkModule), typeof(MetroDevABMCoreModule))]
    public class MetroDevABMDataModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = "Default";
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
            Database.SetInitializer<MetroDevABMDbContext>(null);
        }
    }
}
