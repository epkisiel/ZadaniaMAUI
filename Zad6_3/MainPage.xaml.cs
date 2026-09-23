namespace Zad6_3
{
    public partial class MainPage : ContentPage
    {
        int liczba = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void MinusButton_Clicked(object sender, EventArgs e)
        {
            if (liczba > 0)
            {
                liczba--;
                LiczbaLabel.Text = "Liczba: " + liczba;
            }
        }

        private void PlusButton_Clicked(object sender, EventArgs e)
        {
            liczba++;
            LiczbaLabel.Text = "Liczba: " + liczba;
        }

        private void ZerujButton_Clicked(object sender, EventArgs e)
        {
            liczba = 0;
            LiczbaLabel.Text = "Liczba: " + liczba;
        }
    }
}
