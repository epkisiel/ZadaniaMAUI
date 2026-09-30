
using System.Collections.ObjectModel;

namespace Zad11_3
{
    public partial class MainPage : ContentPage
    {
        ObservableCollection<string> listaKolorow=new ObservableCollection<string>();

        public MainPage()
        {
            InitializeComponent();
            AktualizujDuzyProstokat();
            AktualizujZapisSzesnastkowy();
            ListaKolorow.ItemsSource = listaKolorow;
        }

        private void SuwakZmieniony(object sender, ValueChangedEventArgs e)
        {
            AktualizujDuzyProstokat();
            AktualizujZapisSzesnastkowy();
        }
        private void PobierzKolor(object sender, EventArgs e)
        {
            int r = (int)suwakR.Value;
            int g = (int)suwakG.Value;
            int b = (int)suwakB.Value;

            if (etykietaPobrany.Parent is Border ramka)
            {
                ramka.BackgroundColor = Color.FromRgb(r, g, b);
            }
            etykietaPobrany.Text = r + ", " + g + ", " + b;

            listaKolorow.Add(etykietaPobrany.Text);
        }
        private void AktualizujDuzyProstokat()
        {
            int r = (int)suwakR.Value;
            int g = (int)suwakG.Value;
            int b = (int)suwakB.Value;

            etykietaR.Text = r.ToString();
            etykietaG.Text = g.ToString();
            etykietaB.Text = b.ToString();

            duzyProstokat.Color = Color.FromRgb(r, g, b);
        }

        private void AktualizujZapisSzesnastkowy()
        {
            int r = (int)suwakR.Value;
            int g = (int)suwakG.Value;
            int b = (int)suwakB.Value;
            etykietaZapisSzesnastkowy.Text = "#" + r.ToString("X2") + g.ToString("X2") + b.ToString("X2");
        }
    }
}
