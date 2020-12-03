using Autofac;
using System;
using System.Collections.Generic;
using System.Text;
using ViewModels;
using Views;

namespace Bootstrapping.Modules
{
    public class ViewModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<MainPage>().SingleInstance();
            builder.RegisterType<MainViewModel>().SingleInstance();

            builder.RegisterType<SettingsPage>().SingleInstance();
            builder.RegisterType<SettingsViewModel>().SingleInstance();

            builder.RegisterType<AboutPage>().SingleInstance();
            builder.RegisterType<AboutViewModel>().SingleInstance();
        }
    }
}
