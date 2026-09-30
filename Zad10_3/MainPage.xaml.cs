namespace Zad10_3
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private void ZastosujButton_Clicked(object sender, EventArgs e)
        {
            int kolor=(int)SzaroscSlider.Value;
            this.BackgroundColor = Color.FromRgb(kolor, kolor, kolor);
        }
    }
}
