namespace Zad3_2
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private void WyczyscButton_Clicked(object sender, EventArgs e)
        {
            EmailEntry.Text = "";
            TelefonEntry.Text = "";
        }
    }
}
