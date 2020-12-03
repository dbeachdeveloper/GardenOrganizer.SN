using System.Threading.Tasks;
using ViewModels;

namespace Navigation
{
    public interface INavigator
    {
        Task PopAsync();

        Task PopToRootAsync();

        Task PushAsync<TViewModel>()
            where TViewModel : class, IViewModel;

        Task PushModalAsync<TViewModel>()
            where TViewModel : class, IViewModel;
    }
}
