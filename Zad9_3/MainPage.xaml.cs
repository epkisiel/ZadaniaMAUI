using System.Collections.ObjectModel;

namespace Zad9_3
{
    public partial class MainPage : ContentPage
    {
        private ObservableCollection<string> listaZakupow = new ObservableCollection<string>();

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
                LiczbaLabel.Text = "Liczba produktów na liście: " + listaZakupow.Count;
            }
        }

        private void UsunButton_Clicked(object sender, EventArgs e)
        {
            if(ListaZakupow.SelectedItem != null)
            {
                string zaznaczone = (string)ListaZakupow.SelectedItem;
                listaZakupow.Remove(zaznaczone);
                LiczbaLabel.Text = "Liczba produktów na liście: " + listaZakupow.Count;
            }
        }
    }
}
