using Navigation;
using System;
using System.Windows.Input;
using Messages;
using Xamarin.Forms;

namespace ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        public MainViewModel(INavigator navigator, IToastMessage toastMessage) 
            : base(navigator, toastMessage)
        {
            SettingsCommand = new Command(NavigateSettingsPage);
            AboutCommand = new Command(NavigateAboutPage);
        }

        public ICommand SettingsCommand { get; set; }

        public ICommand AboutCommand { get; set; }

        private async void NavigateSettingsPage()
        {
            try
            {
                await GetNavigator().PushAsync<SettingsViewModel>();
            }
            catch (Exception ex)
            {
                GetToastMessage().Show(ex.Message);
            }
        }

        private async void NavigateAboutPage()
        {
            try
            {
                await GetNavigator().PushAsync<AboutViewModel>();
            }
            catch (Exception ex)
            {
                GetToastMessage().Show(ex.Message);
            }
        }
    }
}
