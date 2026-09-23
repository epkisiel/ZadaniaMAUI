namespace Zad4_2
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private void ZapiszSieButton_Clicked(object sender, EventArgs e)
        {
            string certyfikat;
            string poleWiedzy;
            if (CertyfikatSwitch.IsToggled)
            {
                certyfikat = "Włączono przełącznik certyfikatu";
            }
            else
            {
                certyfikat = "Nie włączono przełącznika certyfikatu";
            }
            if (WiedzaCheckBox.IsChecked)
            {
                poleWiedzy = "Zaznaczono pole wiedzy";
            }
            else
            {
                poleWiedzy = "Nie zaznaczono pola wiedzy";
            }

            PodsumowanieLabel.Text="Podsumowanie\n"+ImieEntry.Text+"\n"+poleWiedzy+"\n"+certyfikat;
        }
    }
}
