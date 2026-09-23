namespace Zad2_3
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private void PokazButton_Clicked(object sender, EventArgs e)
        {
            if (MiastoEntry.Text == "" ||MiastoEntry.Text==null||ImieEntry.Text==null|| ImieEntry.Text == "")
            {
                WynikLabel.Text = "Uzupełnij oba pola";
            }
            else
            {
                WynikLabel.Text = "Witaj, "+ImieEntry.Text+" z miasta " + MiastoEntry.Text;
            }
        }
    }
}
