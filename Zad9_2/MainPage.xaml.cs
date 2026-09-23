using System.Collections.ObjectModel;

namespace Zad9_2
{
    public partial class MainPage : ContentPage
    {
        private ObservableCollection<string> listaZakupow=new ObservableCollection<string>();

        public MainPage()
        {
            InitializeComponent();
            ListaZakupow.ItemsSource = listaZakupow;
        }

        private void DodajButton_Clicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(ProduktEntry.Text))
            {
                listaZakupow.Add(ProduktEntry.Text);
                ProduktEntry.Text = "";
            }
        }
    }
}
