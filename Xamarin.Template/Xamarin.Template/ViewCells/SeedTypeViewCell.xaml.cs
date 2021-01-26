using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ViewCells
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SeedTypeViewCell : ViewCell
    {
        /// <summary>
        /// SeedTypeViewCell Constructor
        /// </summary>
        public SeedTypeViewCell()
        {
            InitializeComponent();
        }

        public static readonly BindableProperty TypeProperty =
            BindableProperty.Create("Type", typeof(string), typeof(SeedTypeViewCell), "");

        public string Type
        {
            get { return (string)GetValue(TypeProperty); }
            set { SetValue(TypeProperty, value); }
        }

        protected override void OnBindingContextChanged()
        {
            base.OnBindingContextChanged();

            if (BindingContext != null)
            {
                TypeText.Text = Type;
            }
        }
    }
}