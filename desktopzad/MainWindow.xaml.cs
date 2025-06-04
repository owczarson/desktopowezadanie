using System;
using System.Windows;
using System.Windows.Controls;
using DodajPracownika;    


namespace desktopzad
{
    public partial class MainWindow : Window
    {
        Pracownik pracownik = new Pracownik();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void GenerujHaslo_Click(object sender, RoutedEventArgs e)
        {
            int dlugosc = int.TryParse(txtIloscZnakow.Text, out int wynik) ? wynik : 5;
            bool litery = chkLitery.IsChecked == true;
            bool cyfry = chkCyfry.IsChecked == true;
            bool znaki = chkZnaki.IsChecked == true;

            string haslo = pracownik.GenerujHaslo(dlugosc, litery, cyfry, znaki);
            MessageBox.Show(haslo);
        }

        private void Zatwierdz_Click(object sender, RoutedEventArgs e)
        {
            pracownik.Imie = txtImie.Text;
            pracownik.Nazwisko = txtNazwisko.Text;
            pracownik.Stanowisko = (cmbStanowisko.SelectedItem as ComboBoxItem)?.Content.ToString();

            MessageBox.Show(pracownik.ToString());
        }
    }
}
