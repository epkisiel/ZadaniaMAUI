namespace Zad13_2
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        // Metoda ustawiajaca obraz i cene zaleznie od zaznaczonej przesylki 
        private void SprawdzCene(object sender, EventArgs e)
        {
            if (poleP.IsChecked)
            {
                obrazPrzesylki.Source = "pocztowka.png";
                etykietaCena.Text = "Cena: 1 zl";
            }
            else if (poleL.IsChecked)
            {
                obrazPrzesylki.Source = "list.png";
                etykietaCena.Text = "Cena: 1,5 zl";
            }
            else if (poleK.IsChecked)
            {
                obrazPrzesylki.Source = "paczka.png";
                etykietaCena.Text = "Cena: 10 zl";
            }
            else if(polePolecony.IsChecked)
            {
                obrazPrzesylki.Source = "polecony.png";
                etykietaCena.Text = "Cena: 3 zł";
            }
        }

        // Metoda walidujaca kod pocztowy i wyswietlajaca komunikat 
        private async void ZatwierdzPrzesylke(object sender, EventArgs e)
        {
            string kod = poleKod.Text;

            // Pusty kod traktujemy jak nieprawidlowa liczbe cyfr 
            if (string.IsNullOrEmpty(kod) || kod.Length != 5)
            {
                await DisplayAlert("Walidacja","Nieprawidlowa liczba cyfr w kodzie pocztowym", "OK");
                return;
            }

            // Sprawdzamy, czy wszystkie znaki sa cyframi 
            if (!CzySameCyfry(kod))
            {
                await DisplayAlert("Walidacja","Kod pocztowy powinien sie skladac z samych cyfr", "OK");
                return;

            }

            await DisplayAlert("Walidacja","Dane przesylki zostaly wprowadzone", "OK");
        }

        // Metoda pomocnicza sprawdzajaca, czy napis sklada sie z samych cyfr 
        private bool CzySameCyfry(string tekst)
        {
            foreach (char znak in tekst)
            {
                if (!char.IsDigit(znak))
                    return false;
            }
            return true;
        }
    }
}
