using Navigation;
using System;
using System.Windows.Input;
using Messages;
using Xamarin.Forms;

namespace ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        /// <summary>
        /// MainViewModel Constructor
        /// </summary>
        /// <param name="navigator">INavigator view model navigation</param>
        /// <param name="toastMessage">IToastMessage platform specific ToastMessage</param>
        public MainViewModel(INavigator navigator, IToastMessage toastMessage) 
            : base(navigator, toastMessage)
        {
            SettingsCommand = new Command(NavigateSettingsPage);
            AboutCommand = new Command(NavigateAboutPage);
            SeedTypeCommand = new Command(NavigateSeedTypePage);
        }

        /// <summary>
        /// Command to navigate to the Settings view
        /// </summary>
        public ICommand SettingsCommand { get; set; }

        /// <summary>
        /// Command to navigate to the About view
        /// </summary>
        public ICommand AboutCommand { get; set; }

        /// <summary>
        /// Command to navigate to the SeedType view
        /// </summary>
        public ICommand SeedTypeCommand { get; set; }

        /// <summary>
        /// Navigates to SettingsPage
        /// </summary>
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

        /// <summary>
        /// Navigates to SeedTypePage
        /// </summary>
        private async void NavigateSeedTypePage()
        {
            try
            {
                await GetNavigator().PushAsync<SeedTypeViewModel>();
            }
            catch (Exception ex)
            {
                GetToastMessage().Show(ex.Message);
            }
        }

        /// <summary>
        /// Navigates to the AboutPage
        /// </summary>
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
