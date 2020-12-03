using Autofac;
using Bootstrapping.Modules;
using Factory;
using ViewModels;
using Views;
using Xamarin.Forms;

namespace Bootstrapping
{
    public class BootStrapper : AutofacBootStrapper
    {
        private App _app;

        public BootStrapper(App app)
        {
            _app = app;
        }

        protected override void ConfigureContainer(ContainerBuilder builder)
        {
            base.ConfigureContainer(builder);

            builder.RegisterModule<ViewModule>();
        }

        protected override void ConfigureApplication(IContainer container)
        {
            IViewFactory viewFactory = container.Resolve<IViewFactory>();
            Page mainPage = viewFactory.Resolve<MainViewModel>();
            NavigationPage navigationPage = new NavigationPage(mainPage);
            _app.MainPage = navigationPage;
        }

        protected override void RegisterViews(IViewFactory viewFactory)
        {
            viewFactory.Register<MainViewModel, MainPage>();
            viewFactory.Register<SettingsViewModel, SettingsPage>();
            viewFactory.Register<AboutViewModel, AboutPage>();
        }
    }
}
