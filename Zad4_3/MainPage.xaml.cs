namespace Zad4_3
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void ZapiszSieButton_Clicked(object sender, EventArgs e)
        {
            if (ImieEntry.Text == "" || ImieEntry.Text == null)
            {
                PodsumowanieLabel.Text = "Podaj imię i nazwisko";
            }
            else
            {
                string certyfikat;
                string poleWiedzy;
                string formaKursu="";
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

                if(StacjonarnyRadioButton.IsChecked)
                {
                    formaKursu = "Stacjonarny";
                }
                else if(OnlineRadioButton.IsChecked) {
                    formaKursu = "Online";
                }
                else if (HybrydowyRadioButton.IsChecked)
                {
                    formaKursu = "Hybrydowy";
                }

                PodsumowanieLabel.Text = "Podsumowanie\n" + ImieEntry.Text + "\nWybrana forma kursu: "+formaKursu+"\n" + poleWiedzy + "\n" + certyfikat+"\nOczekiwania: "+OczekiwaniaEditor.Text;
            }
        }
    }
}
