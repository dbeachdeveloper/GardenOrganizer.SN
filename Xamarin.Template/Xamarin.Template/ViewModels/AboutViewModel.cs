using Messages;
using Navigation;

namespace ViewModels
{
    public class AboutViewModel : BaseViewModel
    {
        public AboutViewModel(INavigator navigator, IToastMessage toastMessage)
            : base(navigator, toastMessage)
        {

        }

        public string AboutText
        {
            get
            {
                return "About Text";
            }
        }
    }
}
