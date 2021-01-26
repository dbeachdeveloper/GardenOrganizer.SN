using Autofac;
using Factory;
using ViewModels;
using XamarinUI.Views;

namespace Bootstrapping.Modules
{
    public class ViewModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ViewFactory>().As<IViewFactory>().SingleInstance();

            builder.RegisterType<MainPage>().SingleInstance();
            builder.RegisterType<MainViewModel>().SingleInstance();

            builder.RegisterType<SettingsPage>().SingleInstance();
            builder.RegisterType<SettingsViewModel>().SingleInstance();

            builder.RegisterType<AboutPage>().SingleInstance();
            builder.RegisterType<AboutViewModel>().SingleInstance();

            builder.RegisterType<SeedListPage>().SingleInstance();
            builder.RegisterType<SeedListViewModel>().SingleInstance();

            builder.RegisterType<SeedTypePage>().SingleInstance();
            builder.RegisterType<SeedTypeViewModel>().SingleInstance();

            builder.RegisterType<AddNewSeedTypePage>().SingleInstance();
            builder.RegisterType<AddNewSeedTypeViewModel>().SingleInstance();
        }
    }
}
