namespace Zad3_3
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private void ZamowButton_Clicked(object sender, EventArgs e)
        {
            string komunikat = "";
            if (ProduktEntry.Text == "" || ProduktEntry.Text == null || IloscEntry.Text == "" || IloscEntry.Text == null || AdresEntry.Text == "" || AdresEntry.Text == null)
            {
                DisplayAlert("", "Uzupełnij wszystkie pola", "OK");
            }
            else
            {
                DisplayAlert("Podsumowanie", "Produkt: "+ProduktEntry.Text+", ilość: "+IloscEntry.Text+", adres: "+AdresEntry.Text,"OK");
            }
        }
    }
}
