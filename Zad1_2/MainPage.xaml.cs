namespace Zad1_2
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnZmienButtonClicked(object? sender, EventArgs e)
        {
            PowitanieLabel.Text = "Dziękujemy za uruchomienie aplikacji";
        }
    }
}
