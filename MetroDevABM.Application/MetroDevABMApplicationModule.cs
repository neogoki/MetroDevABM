using System.Reflection;
using Abp.AutoMapper;
using Abp.Modules;

namespace MetroDevABM
{
    [DependsOn(typeof(MetroDevABMCoreModule), typeof(AbpAutoMapperModule))]
    public class MetroDevABMApplicationModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
            //We must declare mappings to be able to use AutoMapper
            Configuration.Modules.AbpAutoMapper().Configurators.Add(mapper =>
            {
                DtoMappings.Map(mapper);
            });
        }
    }
}
