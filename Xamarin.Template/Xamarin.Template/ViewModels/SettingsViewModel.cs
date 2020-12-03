using Navigation;
using Messages;

namespace ViewModels
{
    public class SettingsViewModel : BaseViewModel
    {

        public SettingsViewModel(INavigator navigator, IToastMessage toastMessage)
            : base(navigator, toastMessage)
        {
            
        }

        public string SettingsText
        {
            get
            {
                return "Settings Text";
            }
        }
    }
}
