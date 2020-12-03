using Factory;
using System;
using System.Threading.Tasks;
using ViewModels;
using Xamarin.Forms;

namespace Navigation
{
    public class Navigator : INavigator
    {
        private readonly Lazy<INavigation> _navigation;
        private readonly IViewFactory _viewFactory;

        public Navigator(Lazy<INavigation> navigation, IViewFactory viewFactory)
        {
            _navigation = navigation;
            _viewFactory = viewFactory;
        }

        private INavigation Navigation
        {
            get
            {
                return _navigation.Value;
            }
        }

        public async Task PopAsync()
        {
            await Navigation.PopAsync();
        }

        public async Task PopToRootAsync()
        {
            await Navigation.PopToRootAsync();
        }

        public async Task PushAsync<TViewModel>()
            where TViewModel : class, IViewModel
        {
            await Navigation.PushAsync(_viewFactory.Resolve<TViewModel>());
        }

        public async Task PushModalAsync<TViewModel>() 
            where TViewModel : class, IViewModel
        {
            await Navigation.PushModalAsync(_viewFactory.Resolve<TViewModel>());
        }
    }
}
