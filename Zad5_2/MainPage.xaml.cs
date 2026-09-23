namespace Zad5_2
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private void OcenaSlider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            OcenaLabel.Text = "Ocena: " + (int)OcenaSlider.Value;
        }
    }
}
