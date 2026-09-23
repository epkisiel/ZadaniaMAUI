namespace Zad7_2
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private void CornsilkButton_Clicked(object sender, EventArgs e)
        {
            this.BackgroundColor = Color.FromArgb("#FFF8DC");
            AktualnyLabel.Text = "Aktualny kolor: Cornsilk (#FFF8DC)";
        }

        private void PeruButton_Clicked(object sender, EventArgs e)
        {
            this.BackgroundColor = Color.FromArgb("#CD853F");
            AktualnyLabel.Text = "Aktualny kolor: Peru (#CD853F)";
        }
    }
}
