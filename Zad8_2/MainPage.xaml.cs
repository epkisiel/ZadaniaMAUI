
namespace Zad8_2
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            string podaneDane = WiekEntry.Text;
            if(!int.TryParse(podaneDane, out int wiek))
            {
                WiekLabel.IsVisible = false;
                DisplayAlert("", "Podaj wiek jako liczbę", "OK");
            }
            else if (wiek < 1 || wiek > 120)
            {
                WiekLabel.IsVisible = false;
                DisplayAlert("", "Wiek musi być z zakresu 1-120","OK");
            }
            else
            {
                WiekLabel.IsVisible = true;
                WiekLabel.Text = "Twój wiek to: " + wiek;
            }
        }
    }
}
