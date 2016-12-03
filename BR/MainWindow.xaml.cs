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
using System.Windows.Navigation;
using System.Windows.Shapes;
using Mono.Security;
using Npgsql;

namespace BR
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public abstract class Train
        {
            public int Track { get; set; }
            public string Name { get; set; }
            public string Route { get; set; }
            public int Departure { get; set; }
            public int Arrival { get; set; }
            public int NumberOfCar { get; set; }
            public Train() { }

            public Train(int Track1, string Name1, string Route1, int Departure1, int Arrival1, int NumberOfCar1)
            {
                Track = Track1;
                Name = Name1;
                Route = Route1;
                Departure = Departure1;
                Arrival = Arrival1;
                NumberOfCar = NumberOfCar1;
            }
        }
        public class Cargo : Train
        {
            public string TypeOfCargo { get; set; }
            public int AmountOfCars { get; set; }
            public Cargo() { }
            public Cargo(int Track1, string Name1, string Route1, int Departure1, int Arrival1, int NumberOfCar1, string TypeOfCargo1, int AmountOfCars1)
                : base(Track1, Name1, Route1, Departure1, Arrival1, NumberOfCar1)
            {
                TypeOfCargo = TypeOfCargo1;
                AmountOfCars = AmountOfCars1;
            }
        }
        public class Passenger : Train
        {
            public double Price { get; set; }
            public bool FreePlaces { get; set; }

            public Passenger() { }
            public Passenger(int Track1, string Name1, string Route1, int Departure1, int Arrival1, int NumberOfCar1, double Price1, bool FreePlaces1)
                : base(Track1, Name1, Route1, Departure1, Arrival1, NumberOfCar1)
            {
                Price = Price1;
                FreePlaces = FreePlaces1;
            }
        }

        public class Suburban : Passenger
        {
            public bool Privilege { get; set; }
            public Suburban() { }
            public Suburban(int Track1, string Name1, string Route1, int Departure1, int Arrival1, int NumberOfCar1, double Price1, bool FreePlaces1, bool Privilege1)
                : base(Track1, Name1, Route1, Departure1, Arrival1, NumberOfCar1, Price1, FreePlaces1)
            {
                Privilege = Privilege1;

            }
        }
        public class Distant : Passenger
        {
            public string TypeOfPlaces { get; set; }
            public Distant() { }
            public Distant(int Track1, string Name1, string Route1, int Departure1, int Arrival1, int NumberOfCar1, double Price1, bool FreePlaces1, string TypeOfPlaces1)
                : base(Track1, Name1, Route1, Departure1, Arrival1, NumberOfCar1, Price1, FreePlaces1)
            {

                TypeOfPlaces = TypeOfPlaces1;
            }
        }


        public MainWindow()
        {
            InitializeComponent();


            bool boolfound = false;
            using (NpgsqlConnection conn = new NpgsqlConnection("Server=localhost; Port=5432; User Id=postgres; Password=yourpass; Database=Test1"))
            {
                conn.Open();

                NpgsqlCommand cmd = new NpgsqlCommand("SELECT * FROM Table1", conn);
                NpgsqlDataReader dr = cmd.ExecuteReader();
                // if (dr.Read())
                while (dr.Read())
                {
                    boolfound = true;
                    // TextBox1.Text=("connection established");  cmd.ExecuteScalar().ToString();

                    TextBox1.Text += dr[0] + " " + dr[1] + "\n";


                }
                if (boolfound == false)
                {
                    TextBox1.Text = ("Data does not exist");
                }
                dr.Close();
            }

        }

        private void button_Click(object sender, RoutedEventArgs e)
        {

            Cargo a;
            a = new Cargo();
            //textBox.Text = "track" + a.Track + " name" + a.Name + " route" + a.Route + " departure" + a.Departure + " arrival" + a.Arrival + " numberofcars" + a.NumberOfCar + " typeofcargo" + a.TypeOfCargo + " amountofcars" + a.AmountOfCars;
            
            a=Administrator.set_Cargo(5, "name1", "r1", 5, 5, 5, "n/a", 5);
            TextBox1.Text = Administrator.get_Cargo_name(a) + " " + Administrator.get_Cargo_Route(a);

            //textBox.Text += "\n"+"track" + a.Track + " name" + a.Name + " route" + a.Route + " departure" + a.Departure + " arrival" + a.Arrival + " numberofcars" + a.NumberOfCar + " typeofcargo" + a.TypeOfCargo + " amountofcars" + a.AmountOfCars; ;
        }
    }

}
