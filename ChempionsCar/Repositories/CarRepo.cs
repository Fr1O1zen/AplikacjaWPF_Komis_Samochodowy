using ChempionsCar.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;
using ChempionsCar;
using System.Collections;

namespace ChempionsCar.Repositories
{
    internal class CarRepo:IcarRepo
    {
      public List<Car> QueryCar(string Query)
        {
            MainWindow mainWindow = new MainWindow();
            //Połączenie z bazą
            string connectionString = "server=127.0.0.1;user=root;database=chcar;port=3306;password=root;";
            //Lista pojazdow 
            List<Car> carsList = new List<Car>();
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using MySqlCommand command = new MySqlCommand(Query, connection);
                    using MySqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Car car = new Car()
                        {
                            //Utwórz obiekt typu Car I dodaj do kolekcji typu Lista
                            ID = reader.GetInt32("ID"),
                            Brand = reader.GetString("Marka"),
                            Model = reader.GetString("Model"),
                            Mileage = reader.GetFloat("Przebieg"),
                            Power = reader.GetInt32("Moc"),
                            Engine = reader.GetFloat("Pojemnosc"),
                            Fuel = reader.GetString("Paliwo"),
                            Year = reader.GetInt32("DataProd"),
                            Price = reader.GetFloat("Cena"),
                            Description = reader.GetString("Opis")
                        };
                        carsList.Add(car);
                    }
                    return carsList;


                }
                catch (Exception ex)
                {
                    return null;
                }
                finally
                {
                    connection.Close();
                }
            }

        }
    }
}
