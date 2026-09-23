namespace Zad7_3
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
            this.BackgroundColor = Color.FromArgb("#FFFFFF");
        }

        private void slider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            int r=(int)Rslider.Value;
            int g=(int)Gslider.Value;
            int b = (int)Bslider.Value;
            string kolor = "#" + r.ToString("X2") + g.ToString("X2") + b.ToString("X2");
            this.BackgroundColor = Color.FromArgb(kolor);
            AktualnyLabel.Text = "Aktualny kolor: " + kolor;
        }

    }
}
