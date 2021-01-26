
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ViewCells
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SeedViewCell : ViewCell
    {
        /// <summary>
        /// SeedViewCell Constructor
        /// </summary>
        public SeedViewCell()
        {
            InitializeComponent();
        }

        public static readonly BindableProperty TypeProperty =
            BindableProperty.Create("Type", typeof(string), typeof(SeedViewCell), "");

        public static readonly BindableProperty VarietyProperty =
            BindableProperty.Create("Variety", typeof(string), typeof(SeedViewCell), "");

        public static readonly BindableProperty ManufacturerProperty =
            BindableProperty.Create("Type", typeof(string), typeof(SeedViewCell), "");

        public static readonly BindableProperty SproutDaysProperty =
            BindableProperty.Create("SproutDays", typeof(string), typeof(SeedViewCell), "");

        public static readonly BindableProperty TemperaturesProperty =
            BindableProperty.Create("Temperatures", typeof(string), typeof(SeedViewCell), "");

        public static readonly BindableProperty SunLightProperty =
            BindableProperty.Create("SunLight", typeof(string), typeof(SeedViewCell), "");

        public static readonly BindableProperty SeedDepthProperty =
            BindableProperty.Create("SeedDepth", typeof(string), typeof(SeedViewCell), "");

        public static readonly BindableProperty PlantSpacingProperty =
            BindableProperty.Create("PlantSpacing", typeof(string), typeof(SeedViewCell), "");

        public static readonly BindableProperty FrostProperty =
            BindableProperty.Create("Frost", typeof(string), typeof(SeedViewCell), "");

        public static readonly BindableProperty PurchaseProperty =
            BindableProperty.Create("{Purchase", typeof(string), typeof(SeedViewCell), "");

        public static readonly BindableProperty ImageUrlProperty =
            BindableProperty.Create("ImageUrl", typeof(string), typeof(SeedViewCell), "");

        public string Type
        {
            get { return (string)GetValue(TypeProperty); }
            set { SetValue(TypeProperty, value); }
        }

        public string Variety
        {
            get { return (string)GetValue(VarietyProperty); }
            set { SetValue(VarietyProperty, value); }
        }

        public string Manufacturer
        {
            get { return (string)GetValue(ManufacturerProperty); }
            set { SetValue(ManufacturerProperty, value); }
        }

        public string SproutDays
        {
            get { return (string)GetValue(SproutDaysProperty); }
            set { SetValue(SproutDaysProperty, value); }
        }

        public string Temperatures
        {
            get { return (string)GetValue(TemperaturesProperty); }
            set { SetValue(TemperaturesProperty, value); }
        }

        public string SunLight
        {
            get { return (string)GetValue(SunLightProperty); }
            set { SetValue(SunLightProperty, value); }
        }

        public string SeedDepth
        {
            get { return (string)GetValue(SeedDepthProperty); }
            set { SetValue(SeedDepthProperty, value); }
        }

        public string PlantSpacing
        {
            get { return (string)GetValue(PlantSpacingProperty); }
            set { SetValue(PlantSpacingProperty, value); }
        }

        public string Frost
        {
            get { return (string)GetValue(FrostProperty); }
            set { SetValue(FrostProperty, value); }
        }

        public string Purchase
        {
            get { return (string)GetValue(PurchaseProperty); }
            set { SetValue(PurchaseProperty, value); }
        }

        public string ImageUrl
        {
            get { return (string)GetValue(ImageUrlProperty); }
            set { SetValue(ImageUrlProperty, value); }
        }

        protected override void OnBindingContextChanged()
        {
            base.OnBindingContextChanged();

            if (BindingContext != null)
            {
                TypeText.Text = Type;
                VarietyText.Text = Variety;
                ManufacturerText.Text = Manufacturer;
                SproutDaysText.Text = SproutDays;
                TemperaturesText.Text = Temperatures;
                SunLightText.Text = SunLight;
                SeedDepthText.Text = SeedDepth;
                PlantSpacingText.Text = PlantSpacing;
                FrostText.Text = Frost;
                PurchaseText.Text = Purchase;
                //ImageUrlImg.Source = ImageUrl;
            }
        }
    }
}