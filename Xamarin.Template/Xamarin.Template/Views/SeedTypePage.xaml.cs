using ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinUI.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SeedTypePage : ContentPage
    {
        private IViewModel viewModel;

        public SeedTypePage()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Allows the SeedType ListView to refresh when the page is navigated back to from adding a new SeedType
        /// </summary>
        protected override void OnAppearing()
        {
            viewModel = this.BindingContext as IViewModel;

            viewModel.OnAppearing();
        }
    }
}