using Navigation;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Messages;

namespace ViewModels
{
    public abstract class BaseViewModel : IViewModel
    {
        private readonly INavigator _navigator;
        private readonly IToastMessage _toastMessage;

        public BaseViewModel(INavigator navigator, IToastMessage toastMessage)
        {
            _navigator = navigator;
            _toastMessage = toastMessage;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public INavigator GetNavigator()
        {
            return _navigator;
        }

        public IToastMessage GetToastMessage()
        {
            return _toastMessage;
        }

        protected virtual void NotifyPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
