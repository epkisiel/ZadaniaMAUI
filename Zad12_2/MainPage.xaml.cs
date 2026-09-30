namespace Zad12_2
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        // Metoda wywolywana po opuszczeniu pola Numer. 
        // Ustawia obrazy na podstawie wpisanego numeru. 
        private void NumerOpuszczony(object sender, FocusEventArgs e)
        {
            string numer = poleNumer.Text;

            // Gdy pole jest puste, nie probujemy ladowac obrazow 

            if (string.IsNullOrWhiteSpace(numer))
            {
                obrazZdjecie.Source = null;
                obrazOdcisk.Source = null;
                return;
            }

            // Skladamy nazwy plikow z numeru, np. 333 –> 333–zdjecie.jpg 
            obrazZdjecie.Source = numer + "–zdjecie.jpg";
            obrazOdcisk.Source = numer + "–odcisk.jpg";
        }

        // Metoda wywolywana po kliknieciu przycisku OK. 
        // Sprawdza wypelnienie pol i wyswietla odpowiedni komunikat. 
        private async void ZatwierdzDane(object sender, EventArgs e)
        {
            string imie = poleImie.Text;
            string nazwisko = poleNazwisko.Text;

            if (string.IsNullOrWhiteSpace(poleNumer.Text))
            {
                await DisplayAlert("Uwaga", "Wprowadz numer", "OK");
                return;
            }
            // Walidacja: imie i nazwisko musza byc wpisane 
            if (string.IsNullOrWhiteSpace(imie) || string.IsNullOrWhiteSpace(nazwisko))
            {
                await DisplayAlert("Uwaga", "Wprowadz dane", "OK");
                return;
            }

            // Ustalamy zaznaczony kolor oczu na podstawie pol wyboru 
            string kolorOczu = PobierzKolorOczu();

            string komunikat = imie + " " + nazwisko + " kolor oczu " + kolorOczu;

            await DisplayAlert("Dane paszportowe", komunikat, "OK");
        }

        // Metoda pomocnicza zwracajaca nazwe zaznaczonego koloru oczu 
        private string PobierzKolorOczu()
        {
            if (oczyNiebieskie.IsChecked)
                return "niebieskie";

            if (oczyZielone.IsChecked)
                return "zielone";

            return "piwne";
        }
    }
}
