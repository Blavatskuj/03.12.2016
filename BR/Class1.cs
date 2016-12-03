using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BR
{
   
        class Administrator
        {
             
        
        public static MainWindow.Cargo set_Cargo( int Track1, string Name1, string Route1, int Departure1, int Arrival1, int NumberOfCar1, string TypeOfCargo1, int AmountOfCars1)
        {
            MainWindow.Cargo a;
            a = new MainWindow.Cargo(Track1, Name1, Route1, Departure1, Arrival1, NumberOfCar1,TypeOfCargo1,AmountOfCars1);
            return a;
        }
        public static MainWindow.Cargo get_Cargo(MainWindow.Cargo a)
        {
            return a;
        }
        public static MainWindow.Cargo set_Cargo_Name(string Name1, MainWindow.Cargo a)
        {
            a.Name = Name1;
            return a;
        }
        public static string get_Cargo_name(MainWindow.Cargo a)
        {
            return a.Name;
        }
        public static MainWindow.Cargo set_Cargo_Track(int Track1, MainWindow.Cargo a)
        {
            a.Track = Track1;
            return a;
        }
        public static int get_Cargo_Track(MainWindow.Cargo a)
        {
            return a.Track;
        }
        public static MainWindow.Cargo set_Cargo_Route(string Route1, MainWindow.Cargo a)
        {
            a.Route = Route1;
            return a;
        }
        public static string get_Cargo_Route(MainWindow.Cargo a)
        {
            return a.Route;
        }
        public static MainWindow.Cargo set_Cargo_Departure(int Departure1, MainWindow.Cargo a)
        {
            a.Departure = Departure1;
            return a;
        }
        public static int get_Cargo_Departure(MainWindow.Cargo a)
        {
            return a.Departure;
        }
        public static MainWindow.Cargo set_Cargo_Arrival(int Arrival1, MainWindow.Cargo a)
        {
            a.Arrival = Arrival1;
            return a;
        }
        public static int get_Cargo_Arrival(MainWindow.Cargo a)
        {
            return a.Arrival;
        }    
        public static MainWindow.Cargo set_Cargo_Number(int NumberOfCar1, MainWindow.Cargo a)
        {
            a.NumberOfCar = NumberOfCar1;
            return a;
        }
        public static int get_Cargo_Number(MainWindow.Cargo a)
        {
            return a.NumberOfCar;
        } 
        public static MainWindow.Passenger set_Passenger(int Track1, string Name1, string Route1, int Departure1, int Arrival1, int NumberOfCar1, double Price1, bool FreePlaces1)
        {
            MainWindow.Passenger a = new MainWindow.Passenger(Track1, Name1, Route1, Departure1, Arrival1, NumberOfCar1, Price1, FreePlaces1);
            return a;
        }
        public static MainWindow.Passenger get_Passenger(MainWindow.Passenger a)
        {
            return a;
        }
        public static MainWindow.Passenger set_Passenger_Name(string Name1, MainWindow.Passenger a)
        {
            a.Name = Name1;
            return a;
        }

        public static string get_Passenger_name(MainWindow.Passenger a)
        {
            return a.Name;
        }
        public static MainWindow.Passenger set_Passenger_Track(int Track1, MainWindow.Passenger a)
        {
            a.Track = Track1;
            return a;
        }
        public static int get_Passenger_Track(MainWindow.Passenger a)
        {
            return a.Track;
        }
        public static MainWindow.Passenger set_Passenger_Route(string Route1, MainWindow.Passenger a)
        {
            a.Route = Route1;
            return a;
        }
        public static string get_Passenger_Route(MainWindow.Passenger a)
        {
            return a.Route;
        }
        public static MainWindow.Passenger set_Passenger_Departure(int Departure1, MainWindow.Passenger a)
        {
            a.Departure = Departure1;
            return a;
        }
        public static int get_Passenger_Departure(MainWindow.Passenger a)
        {
            return a.Departure;
        }
        public static MainWindow.Passenger set_Passenger_Arrival(int Arrival1, MainWindow.Passenger a)
        {
            a.Arrival = Arrival1;
            return a;
        }
        public static int get_Passenger_Arrival(MainWindow.Passenger a)
        {
            return a.Arrival;
        }
        public static MainWindow.Passenger set_Passenger_Number(int NumberOfCar1, MainWindow.Passenger a)
        {
            a.NumberOfCar = NumberOfCar1;
            return a;
        }
        public static int get_Passenger_Number(MainWindow.Passenger a)
        {
            return a.NumberOfCar;
        } 

        public static MainWindow.Distant set_Distant(int Track1, string Name1, string Route1, int Departure1, int Arrival1, int NumberOfCar1, double Price1, bool FreePlaces1, string TypeOfPlaces1)
        {
            MainWindow.Distant a = new MainWindow.Distant(Track1, Name1, Route1, Departure1, Arrival1, NumberOfCar1, Price1, FreePlaces1, TypeOfPlaces1);
            return a;
        }
        public static MainWindow.Distant get_Distant(MainWindow.Distant a)
        {
            return a;
        }

        public static MainWindow.Distant set_Distant_Nam(string Name1, MainWindow.Distant a)
        {
            a.Name = Name1;
            return a;
        }

        public static string get_Distant_name(MainWindow.Distant a)
        {
            return a.Name;
        }
        public static MainWindow.Distant set_Distant_Track(int Track1, MainWindow.Distant a)
        {
            a.Track = Track1;
            return a;
        }
        public static int get_Distant_Track(MainWindow.Distant a)
        {
            return a.Track;
        }
        public static MainWindow.Distant set_Distant_Route(string Route1, MainWindow.Distant a)
        {
            a.Route = Route1;
            return a;
        }
        public static string get_Distant_Route(MainWindow.Distant a)
        {
            return a.Route;
        }
        public static MainWindow.Distant set_Distant_Departure(int Departure1, MainWindow.Distant a)
        {
            a.Departure = Departure1;
            return a;
        }
        public static int get_Distant_Departure(MainWindow.Distant a)
        {
            return a.Departure;
        }
        public static MainWindow.Distant set_Distant_Arrival(int Arrival1, MainWindow.Distant a)
        {
            a.Arrival = Arrival1;
            return a;
        }
        public static int get_Distant_Arrival(MainWindow.Distant a)
        {
            return a.Arrival;
        }
        public static MainWindow.Distant set_Distant_Number(int NumberOfCar1, MainWindow.Distant a)
        {
            a.NumberOfCar = NumberOfCar1;
            return a;
        }
        public static int get_Distant_Number(MainWindow.Distant a)
        {
            return a.NumberOfCar;
        }
        public static MainWindow.Distant set_Distant_TypeOfPlaces(string TypeOfPlaces1, MainWindow.Distant a)
        {
            a.TypeOfPlaces = TypeOfPlaces1;
            return a;
        }
        public static string get_Distant_TypeOfPlaces(MainWindow.Distant a)
        {
            return a.TypeOfPlaces;
        } 
        public static MainWindow.Suburban set_Suburban(int Track1, string Name1, string Route1, int Departure1, int Arrival1, int NumberOfCar1, double Price1, bool FreePlaces1, bool Privilege1)
        {
            MainWindow.Suburban a = new MainWindow.Suburban(Track1, Name1, Route1, Departure1, Arrival1, NumberOfCar1, Price1, FreePlaces1, Privilege1);
            return a;
        }
        public static MainWindow.Suburban get_Suburban(MainWindow.Suburban a)
        {
            return a;
        }
    
        public static MainWindow.Suburban set_Suburban_Name(string Name1, MainWindow.Suburban a)
        {
            a.Name = Name1;
            return a;
        }

        public static string get_Suburban_name(MainWindow.Suburban a)
        {
            return a.Name;
        }
        public static MainWindow.Suburban set_Suburban_Track(int Track1, MainWindow.Suburban a)
        {
            a.Track = Track1;
            return a;
        }
        public static int get_Suburban_Track(MainWindow.Suburban a)
        {
            return a.Track;
        }
        public static MainWindow.Suburban set_Suburban_Route(string Route1, MainWindow.Suburban a)
        {
            a.Route = Route1;
            return a;
        }
        public static string get_Suburban_Route(MainWindow.Suburban a)
        {
            return a.Route;
        }
        public static MainWindow.Suburban set_Suburban_Departure(int Departure1, MainWindow.Suburban a)
        {
            a.Departure = Departure1;
            return a;
        }
        public static int get_Suburban_Departure(MainWindow.Suburban a)
        {
            return a.Departure;
        }
        public static MainWindow.Suburban set_Suburban_Arrival(int Arrival1, MainWindow.Suburban a)
        {
            a.Arrival = Arrival1;
            return a;
        }
        public static int get_Suburban_Arrival(MainWindow.Suburban a)
        {
            return a.Arrival;
        }
        public static MainWindow.Suburban set_Suburban_Number(int NumberOfCar1, MainWindow.Suburban a)
        {
            a.NumberOfCar = NumberOfCar1;
            return a;
        }
        public static int get_Suburban_Number(MainWindow.Suburban a)
        {
            return a.NumberOfCar;
        }
        public static MainWindow.Suburban set_Suburban_Privilege(Boolean Privilege1, MainWindow.Suburban a)
        {
            a.Privilege = Privilege1;
            return a;
        }
        public static Boolean get_Suburban_Privilege(MainWindow.Suburban a)
        {
            return a.Privilege;
        } 
        }
    class User
    {
        public static MainWindow.Cargo get_Cargo(MainWindow.Cargo a)
        {
            return a;
        }
        public static MainWindow.Passenger get_Passenger(MainWindow.Passenger a)
        {
            return a;
        }
        public static MainWindow.Distant get_Distant(MainWindow.Distant a)
        {
            return a;
        }
        public static MainWindow.Suburban get_Suburban(MainWindow.Suburban a)
        {
            return a;
        }
    }

   
}
