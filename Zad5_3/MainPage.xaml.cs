namespace Zad5_3
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private void ZarezerwujButton_Clicked(object sender, EventArgs e)
        {
            string sala = SalaPicker.SelectedItem?.ToString();
            if (sala != null)
            {
                DateTime data = (DateTime)RezerwacjaDataPicker.Date;
                PodsumowanieLabel.Text = "Podsumowanie: \n" + sala + "\nLiczba osób: " + LiczbaOsobStepper.Value + "\n" + $"{data:dd.MM.yyyy}";
            }
            else
            {
                PodsumowanieLabel.Text = "Wybierz salę";
            }
        }
    }
}
