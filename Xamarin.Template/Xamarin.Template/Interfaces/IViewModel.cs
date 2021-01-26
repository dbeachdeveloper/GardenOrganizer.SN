using System.Collections.Generic;
using System.ComponentModel;

namespace ViewModels
{
    public interface IViewModel : INotifyPropertyChanged
    {
        Dictionary<string, string> Parameters { get; set; }

        void OnAppearing();
    }
}
