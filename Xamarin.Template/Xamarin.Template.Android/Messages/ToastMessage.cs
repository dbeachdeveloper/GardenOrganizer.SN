using Android.App;
using Android.Widget;
using Messages;

namespace Messages.Android
{
    public class ToastMessage : IToastMessage
    {
        public void Show(string message)
        {
            Toast.MakeText(Application.Context, message, ToastLength.Long).Show();
        }
    }
}