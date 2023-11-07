using System;
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
using MySqlConnector;
namespace ChempionsCar
{
    /// <summary>
    /// Logika interakcji dla klasy AddCar.xaml
    /// </summary>
    public partial class AddCar : Window
    {
        public AddCar()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender,  TextChangedEventArgs e)
        {

        }

        private void AddCarDB(object button, RoutedEventArgs e)
        {
            TextBox Marka = this.Marka;
            TextBox Model = this.Model;
            TextBox Przebieg = this.Przebieg;
            TextBox Moc = this.Moc;
            TextBox Pojemnosc = this.Pojemnosc;
            ComboBox Paliwo = this.Paliwo;
            DatePicker DataProdControl = this.DataProd;
            TextBox Cena = this.Cena;
            TextRange OpisControl = new TextRange(this.Opis.Document.ContentStart, this.Opis.Document.ContentEnd);
            TextBox Tag = this.Tag;
            string FullTag=Tag.Text+$",{Marka.Text},{Model.Text},{Paliwo.Text}";
            string Opis = OpisControl.Text;
            

            if (
                string.IsNullOrEmpty(Marka.Text)||
                string.IsNullOrEmpty(Model.Text)||
                string.IsNullOrEmpty(Przebieg.Text)||
                string.IsNullOrEmpty(Moc.Text)||
                string.IsNullOrEmpty(Pojemnosc.Text)||
                Paliwo.SelectedIndex==-1||
                DataProdControl.SelectedDate==null||
                string.IsNullOrEmpty(Cena.Text)
                )
            {
                MessageBox.Show("Wypełnij wymagane pola");
            }
            else
            {
                string connectionString = "server=127.0.0.1;user=root;database=chcar;port=3306;password=root;";
                string Query = $"INSERT INTO cart VALUES (NULL,'{Marka.Text}','{Model.Text}','{Paliwo.Text}',{Moc.Text},{Cena.Text},{Przebieg.Text},{Pojemnosc.Text},{DataProdControl.SelectedDate.Value.Year},'{Opis}','{FullTag}')";
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();
                        MySqlCommand command = new MySqlCommand(Query, connection);
                        command.ExecuteNonQuery();
                        MessageBox.Show("pojazd dodany !");
                        this.Hide();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("coś poszło nie tak !");
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
                MessageBox.Show(Query);
            }

        }

    }
}
