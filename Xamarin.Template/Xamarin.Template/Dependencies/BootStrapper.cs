using Autofac;
using Bootstrapping.Modules;
using Factory;
using ViewModels;
using XamarinUI.Views;
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
            builder.RegisterModule<BusinessModule>();
        }

        /// <summary>
        /// Sets the main page as a NavigationPage
        /// </summary>
        /// <param name="container">IContainer</param>
        protected override void ConfigureApplication(IContainer container)
        {
            IViewFactory viewFactory = container.Resolve<IViewFactory>();
            Page mainPage = viewFactory.Resolve<MainViewModel>();
            NavigationPage navigationPage = new NavigationPage(mainPage);
            _app.MainPage = navigationPage;
        }

        /// <summary>
        /// Registers all of the views with their view models.  This allows for view model navigation.
        /// </summary>
        /// <param name="viewFactory">IViewFactory</param>
        protected override void RegisterViews(IViewFactory viewFactory)
        {
            viewFactory.Register<MainViewModel, MainPage>();
            viewFactory.Register<SettingsViewModel, SettingsPage>();
            viewFactory.Register<AboutViewModel, AboutPage>();
            viewFactory.Register<SeedListViewModel, SeedListPage>();
            viewFactory.Register<SeedTypeViewModel, SeedTypePage>();
            viewFactory.Register<AddNewSeedTypeViewModel, AddNewSeedTypePage>();
        }
    }
}
