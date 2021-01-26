using Autofac;
using Business.Services;
using FatHead.Converters;
using Services;

namespace Bootstrapping.Modules
{
    public class BusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            //builder.RegisterType<SeedTestService>().As<ISeedService>().SingleInstance();
            builder.RegisterType<SeedTypeTestService>().As<ISeedTypeService>().SingleInstance();
            builder.RegisterType<SeedTestService>().As<ISeedService>().SingleInstance();
            builder.RegisterType<ModelConverter>().As<IModelConverter>().SingleInstance();
        }
    }
}
