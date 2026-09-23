namespace Zad1_3
{
    public partial class MainPage : ContentPage
    {
        int licznik = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnZmienButtonClicked(object? sender, EventArgs e)
        {
            PowitanieLabel.Text = "Aplikacja działa poprawnie";
            licznik++;
            LicznikLabel.Text = "Kliknięto " + licznik + " razy";
        }

        private void ResetButton_Clicked(object sender, EventArgs e)
        {
            PowitanieLabel.Text = "Witamy w aplikacji";
            licznik++;
            LicznikLabel.Text = "Kliknięto " + licznik + " razy";
        }
        
    }
}
