namespace Zad14_3
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private void SprawdzButton_Clicked(object sender, EventArgs e)
        {
            double wysokosc = this.Height;
            double szerokosc = this.Width;

            RozmiarLabel.Text = "Rozmiar ekranu:\nSzerokość: " + szerokosc + "\nWysokość: " + wysokosc;
        }
    }
}
