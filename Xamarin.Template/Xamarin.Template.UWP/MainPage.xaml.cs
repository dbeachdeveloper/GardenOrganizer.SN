using Messages;
using Messages.UWP;
using System;
using System.Collections.Generic;

namespace Xamarin.Template.UWP
{
    public sealed partial class MainPage
    {
        public MainPage()
        {
            this.InitializeComponent();

            //Load iOS specific dependencies
            Dictionary<Type, Type> mappedTypes = new Dictionary<Type, Type>
            {
                { typeof(IToastMessage), typeof(ToastMessage) }
            };

            XamarinUI.Views.App _app = new XamarinUI.Views.App();
            _app.LoadTypes(mappedTypes);

            LoadApplication(_app);
        }
    }
}
