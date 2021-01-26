using ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinUI.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SeedListPage : ContentPage
    {
        private IViewModel viewModel;

        public SeedListPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            viewModel = this.BindingContext as IViewModel;

            viewModel.OnAppearing();
        }
    }
}