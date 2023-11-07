using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using ChempionsCar.Model;
using MySqlConnector;
namespace ChempionsCar
{
    /// <summary>
    /// Logika interakcji dla klasy CarInfo.xaml
    /// </summary>
    public partial class CarInfo : Window
    {
        int Car_ID;
        public CarInfo(Car pCar)
        {
            InitializeComponent();
            LoadCar(pCar);
            Car_ID=pCar.ID;
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void LoadCar(Car pCar)
        {
            TextBox Marka = this.Marka;
            TextBox Model = this.Model;
            TextBox Przebieg = this.Przebieg;
            TextBox Moc = this.Moc;
            TextBox Pojemnosc = this.Pojemnosc;
            TextBox Paliwo = this.Paliwo;
            TextBox Rok = this.DataProd;
            TextBox Cena = this.Cena;
            TextBox Opis = this.Opis;
            //Wyświetl dane pojazdu w odpowiednim TextBox
            Marka.Text = pCar.Brand;
            Model.Text = pCar.Model;
            Przebieg.Text = (pCar.Mileage).ToString();
            Moc.Text = (pCar.Power).ToString();
            Pojemnosc.Text = (pCar.Engine).ToString();
            Paliwo.Text = pCar.Fuel;
            Rok.Text = (pCar.Year).ToString();
            Cena.Text = (pCar.Price).ToString();
            Opis.Text = pCar.Description;
        }

        private void DeleteCar(object button, RoutedEventArgs e)
        {
            //Polaczenie do bazy --> MySql workbench
            string connectionString = "server=127.0.0.1;user=root;database=chcar;port=3306;password=root;";

            //zapytanie wyswietlajace wszystkie pojazdy z bazy 
            string Query = "DELETE FROM cart WHERE id="+Car_ID;

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using MySqlCommand command = new MySqlCommand(Query, connection);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Pojazd usunięty");
                    this.Hide();
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Coś poszło nie tak");
                }
                finally
                {

                }
               
            }

        }

    }
}
