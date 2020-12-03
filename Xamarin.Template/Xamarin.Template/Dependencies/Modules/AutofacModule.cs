using Autofac;
using Factory;
using Navigation;
using Views;
using Xamarin.Forms;

namespace Bootstrapping.Modules
{
    public class AutofacModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ViewFactory>().As<IViewFactory>().SingleInstance();

            builder.RegisterType<Navigator>().As<INavigator>().SingleInstance();

            //Lazy<> because the Bootstrapping is done before the page is loaded.
            builder.Register<INavigation>(context => App.Current.MainPage.Navigation).SingleInstance();
        }
    }
}
