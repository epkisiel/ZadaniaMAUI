namespace Zad12_3
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void NumerOpuszczony(object sender, FocusEventArgs e)
        {
            string numer = poleNumer.Text;

            if (string.IsNullOrWhiteSpace(numer))
            {
                obrazZdjecie.Source = null;
                obrazOdcisk.Source = null;
                return;
            }

            obrazZdjecie.Source = numer + "–zdjecie.jpg";
            obrazOdcisk.Source = numer + "–odcisk.jpg";
        }

        private async void ZatwierdzDane(object sender, EventArgs e)
        {
            string imie = poleImie.Text;
            string nazwisko = poleNazwisko.Text;

            if (string.IsNullOrWhiteSpace(poleNumer.Text))
            {
                await DisplayAlert("Uwaga", "Wprowadz numer", "OK");
                return;
            }

            if (string.IsNullOrWhiteSpace(imie) || string.IsNullOrWhiteSpace(nazwisko))
            {
                await DisplayAlert("Uwaga", "Wprowadz dane", "OK");
                return;
            }

            string kolorOczu = PobierzKolorOczu();

            string komunikat = imie + " " + nazwisko + " kolor oczu " + kolorOczu;

            await DisplayAlert("Dane paszportowe", komunikat, "OK");
        }

        private string PobierzKolorOczu()
        {
            if (oczyNiebieskie.IsChecked)
                return "niebieskie";

            if (oczyZielone.IsChecked)
                return "zielone";

            return "piwne";
        }

        private void WyczyscDane(object sender, EventArgs e)
        {
            poleNumer.Text = string.Empty;
            poleNazwisko.Text = string.Empty;
            poleImie.Text = string.Empty;
            obrazOdcisk.Source = null;
            obrazZdjecie.Source = null;
            oczyNiebieskie.IsChecked = true;
        }
    }
}
