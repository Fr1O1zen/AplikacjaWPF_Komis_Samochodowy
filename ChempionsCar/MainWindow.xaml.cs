using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ChempionsCar.Model;
using ChempionsCar.Repositories;
using MySqlConnector;
using Org.BouncyCastle.Asn1.Cmp;
using System.Windows.Controls;

namespace ChempionsCar
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
            
          

        }

        //Nowe okno DODAJ pojazd
        private void AddCar_Click(object sender, RoutedEventArgs e)
        {
            AddCar addCar = new AddCar();
            addCar.Show();
        }

        private void SetBackgroundImg(object sender, RoutedEventArgs e )
        {
            var brush = new ImageBrush(new BitmapImage(new Uri("Img/dashboard.jpg", UriKind.Relative)));
            brush.Stretch = Stretch.UniformToFill;
            brush.TileMode = TileMode.None;
            this.Grid.Background = brush;
        }
        
        private void SetBackgroundGrey(object sender, RoutedEventArgs e)
        {
             var brush = new SolidColorBrush(Colors.DarkGray);
            this.Grid.Background = brush;
        }

        private void SetBackgroundWhite(object sender, RoutedEventArgs e)
        {
            var brush = new SolidColorBrush(Colors.White);
            this.Grid.Background = brush;
        }

       

        private void CarListView_Selection(object sender, SelectionChangedEventArgs e)
        {
            if (CarListView.SelectedItem != null)
            {
                // wykonaj akcje na wybranym elemencie
                Car selectedCar = (Car)CarListView.SelectedItem;
                //Nowe okno z info o pojezdzie + przekazanie parametru typu CAR
                CarInfo carInfo = new CarInfo(selectedCar);
                carInfo.Show();
            }
        }

        private void SearchCar(object sender, RoutedEventArgs e)
        {
            CarRepo carRepo = new CarRepo();
            TextBox searchBar = this.SearchTextBox;
            if(string.IsNullOrEmpty(searchBar.Text))
            {
                //zapytanie wyswietlajace wszystkie pojazdy z bazy jesli searchbox pusty
                string Query = "SELECT * FROM cart";
                CarListView.ItemsSource = carRepo.QueryCar(Query);
            }
            else
            {
                //Tworzy zapytanie na podstawie tagów
                if (searchBar.Text.Length > 2)
                {
                    string tagsInput = searchBar.Text;
                    string[] tagsArray = tagsInput.Split(',');
                    string Query = $"SELECT * FROM cart WHERE";
                    for (int i=0; i<tagsArray.Length; i++)
                    {
                        Query = Query + $"`Tag` LIKE '%{tagsArray[i]}%' ";
                        if(i < tagsArray.Length - 1)
                        {
                            Query += "OR ";
                        }
                    }
                    //string tagsCondition = string.Join(",", tagsArray.Select(tag => $"'%{tag}%'"));
                    //  {tagsCondition}  );";
                    CarListView.ItemsSource = carRepo.QueryCar(Query);
                    MessageBox.Show(Query);
                }
            }
        }


    }
}
