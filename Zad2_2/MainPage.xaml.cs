namespace Zad2_2
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private void PokazButton_Clicked(object sender, EventArgs e)
        {
            WynikLabel.Text = "Pozdrowienia z miasta: " + MiastoEntry.Text;
        }
    }
}
