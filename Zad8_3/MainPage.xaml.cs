namespace Zad8_3
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private void ObliczButton_Clicked(object sender, EventArgs e)
        {
            string podanaSzerokosc = SzerokoscEntry.Text;
            string podanaWysokosc = WysokoscEntry.Text;

            if(!double.TryParse(podanaWysokosc,out double wysokosc)|| !double.TryParse(podanaSzerokosc, out double szerokosc))
            {
                WynikLabel.IsVisible=false;
                DisplayAlert("Błąd", "Obie wartości należy podać jako liczby", "OK");
            }
            else if(wysokosc<=0 || szerokosc <= 0)
            {
                WynikLabel.IsVisible = false;
                DisplayAlert("Błąd", "Obie wartości muszą być większe od zera", "OK");
            }
            else
            {
                WynikLabel.IsVisible=true;
                WynikLabel.Text = "Pole: " + (szerokosc * wysokosc);
            }
        }

        private async void WyczyscButton_Clicked(object sender, EventArgs e)
        {
            bool potwierdzenie = await DisplayAlert("Czy na pewno wyczyścić dane?", "", "Tak", "Nie");
            if (potwierdzenie)
            {
                SzerokoscEntry.Text = "";
                WysokoscEntry.Text = "";
                WynikLabel.IsVisible= false;
            }
        }
    }
}
