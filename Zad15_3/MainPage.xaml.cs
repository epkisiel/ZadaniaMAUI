using System.Globalization;

namespace Zad15_3
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Oblicz(object sender, EventArgs e)
        {
            if (!double.TryParse(poleKwota.Text, NumberStyles.Any,
              CultureInfo.InvariantCulture, out double kwota) || kwota < 0)
            {
                await DisplayAlert("Uwaga", "Wprowadz poprawna kwote", "OK");
                return;
            }
            if(!int.TryParse(poleLiczbaOsob.Text, out int liczbaOsob) || liczbaOsob < 0)
            {
                await DisplayAlert("Uwaga", "Wprowadź poprawną liczbę osób", "OK");
                return;
            }

            double procent = PobierzStawke();

            double napiwek = kwota * procent;
            double razem = kwota + napiwek;
            double naOsobe = razem / liczbaOsob;

            etykietaNapiwek.Text = "Napiwek: " + napiwek.ToString("F2") + " zl";
            etykietaRazem.Text = "Razem: " + razem.ToString("F2") + " zl";
            etykietaNaOsobe.Text = "Na osobę: " + naOsobe.ToString("F2") + " zl";
        }

        private double PobierzStawke()
        {
            if (stawka15.IsChecked)
                return 0.15;

            if (stawka20.IsChecked)
                return 0.20;

            if (stawka25.IsChecked)
                return 0.25;

            return 0.10;
        }

        private void Wyczysc(object sender, EventArgs e)
        {
            poleKwota.Text = string.Empty;
            poleLiczbaOsob.Text = string.Empty;
            stawka10.IsChecked = true;
            etykietaNapiwek.Text = "Napiwek: ";
            etykietaRazem.Text = "Razem: ";
            etykietaNaOsobe.Text = "Na osobę: ";
        }
    }
}
