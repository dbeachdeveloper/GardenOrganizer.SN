using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

using Foundation;
using Messages;
using Messages.iOS;
using UIKit;
using XamarinUI.Views;

namespace Xamarin.Template.iOS
{
    // The UIApplicationDelegate for the application. This class is responsible for launching the 
    // User Interface of the application, as well as listening (and optionally responding) to 
    // application events from iOS.
    [Register("AppDelegate")]
    public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
    {
        //
        // This method is invoked when the application has loaded and is ready to run. In this 
        // method you should instantiate the window, load the UI into it and then make the window
        // visible.
        //
        // You have 17 seconds to return from this method, or iOS will terminate your application.
        //
        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            global::Xamarin.Forms.Forms.Init();

            //Load iOS specific dependencies
            Dictionary<Type, Type> mappedTypes = new Dictionary<Type, Type>
            {
                { typeof(IToastMessage), typeof(ToastMessage) }
            };

            string dbName = "matchupanalyzer_db.sqlite";
            string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            string fullPath = Path.Combine(folderPath, dbName);

            App _app = new App(fullPath);
            _app.LoadTypes(mappedTypes);

            LoadApplication(_app);

            return base.FinishedLaunching(app, options);
        }
    }
}
