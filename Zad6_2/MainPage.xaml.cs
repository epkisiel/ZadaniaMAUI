namespace Zad6_2
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private void WartoscSlider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            int wartosc = (int)WartoscSlider.Value;
            LiczbaLabel.Text = "Wartość: " + wartosc;
            if (wartosc < 128)
            {
                SlowoLabel.Text = "Mało";
            }
            else
            {
                SlowoLabel.Text = "Dużo";
            }
        }
    }
}
