using Navigation;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Messages;
using System.Collections.Generic;

namespace ViewModels
{
    public abstract class BaseViewModel : IViewModel
    {
        private readonly INavigator _navigator;
        private readonly IToastMessage _toastMessage;

        /// <summary>
        /// Base Constructor.  All view models will need navigation and toast messages.
        /// </summary>
        /// <param name="navigator">INavigator view model navigation</param>
        /// <param name="toastMessage">IToastMessage platform specific ToastMessage</param>
        public BaseViewModel(INavigator navigator, IToastMessage toastMessage)
        {
            _navigator = navigator;
            _toastMessage = toastMessage;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Returns the INavigator instance
        /// </summary>
        /// <returns>INavigator</returns>
        public INavigator GetNavigator()
        {
            return _navigator;
        }

        /// <summary>
        /// Returns the platform specific ToastMessage
        /// </summary>
        /// <returns>IToastMessage</returns>
        public IToastMessage GetToastMessage()
        {
            return _toastMessage;
        }

        /// <summary>
        /// Stores any parameters passed from one view model to another during navigation
        /// </summary>
        public Dictionary<string, string> Parameters { get; set; }

        /// <summary>
        /// Property changes
        /// </summary>
        /// <param name="propertyName">Name of the property changed</param>
        protected virtual void NotifyPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        /// <summary>
        /// Allows a view model to populate a page OnAppearing.
        /// </summary>
        public virtual void OnAppearing()
        {

        }
    }
}
