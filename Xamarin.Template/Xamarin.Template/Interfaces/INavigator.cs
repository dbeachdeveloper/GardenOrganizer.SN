using System.Threading.Tasks;
using ViewModels;
using Xamarin.Forms;

namespace Navigation
{
    public interface INavigator
    {
        Task PopAsync();

        Task PopToRootAsync();

        Task PushAsync<TViewModel>()
            where TViewModel : class, IViewModel;

        Task PushAsync(Page page);

        Task PushModalAsync<TViewModel>()
            where TViewModel : class, IViewModel;

        Task PushModalAsync(Page page);
    }
}
