using System.Globalization;

namespace Zad15_2
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        // Metoda obliczajaca napiwek i kwote razem po kliknieciu Oblicz 
        private async void Oblicz(object sender, EventArgs e)
        {
            // Walidacja: pole nie moze byc puste i musi byc liczba 
            if (!double.TryParse(poleKwota.Text, NumberStyles.Any,
              CultureInfo.InvariantCulture, out double kwota) || kwota < 0)
            {
                await DisplayAlert("Uwaga", "Wprowadz poprawna kwote", "OK");
                return;
            }

            // Ustalamy procent stawki na podstawie zaznaczonego pola wyboru 
            double procent = PobierzStawke();

            // Wyliczamy napiwek oraz sume razem 
            double napiwek = kwota * procent;
            double razem = kwota + napiwek;

            // Formatujemy wynik do dwoch miejsc po przecinku 
            etykietaNapiwek.Text = "Napiwek: " + napiwek.ToString("F2") + " zl";
            etykietaRazem.Text = "Razem: " + razem.ToString("F2") + " zl";
        }

        // Metoda pomocnicza zwracajaca stawke jako ulamek, np. 0.15 dla 15% 
        private double PobierzStawke()
        {
            if (stawka15.IsChecked)
                return 0.15;

            if (stawka20.IsChecked)
                return 0.20;

            if (stawka25.IsChecked)
                return 0.25;

            // Domyslnie i dla zaznaczonego 10% zwracamy 0.10 
            return 0.10;
        }

        // Metoda czyszczaca formularz do stanu poczatkowego 
        private void Wyczysc(object sender, EventArgs e)
        {
            poleKwota.Text = string.Empty;
            stawka10.IsChecked = true;
            etykietaNapiwek.Text = "Napiwek: ";
            etykietaRazem.Text = "Razem: ";
        }
    }
}
