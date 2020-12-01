using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityHotelsApp
{
    class Program
    {
        class Hotel
        {
            public string City { get; set; }
            public string HotelName { get; set; }
            public string Adress { get; set; }
            public IList<string> Services { get; set; }
            public Hotel()
            {
                Services = new List<string>();
            }
        }
        static void Main(string[] args)
        {
            List<Hotel> hotels = new List<Hotel>
            {
                new Hotel {City ="Toila", HotelName ="Toila Spa Hotel", Adress ="Ranna 12, 41702 Toila, Estonia", Services = new List<string>{  "Wellness", "Ski"} },
                   new Hotel {City ="Tallinn", HotelName ="Hilton", Adress =" Fr. R. Kreutzwaldi 23 , Tallinn City-Centre, 10147 Tallinn, Estonia", Services = new List<string>{ "residence", "Parking", "Pets "} },
                new Hotel {City ="Tallinn", HotelName ="Swissotel", Adress =" Tornimäe 3, Tallinn City-Centre, 10145 Tallinn, Estonia ", Services = new List<string>{ "residence", "Parking ", "Lift"} },
                new Hotel {City ="Tallinn", HotelName ="Hotel Palace ", Adress ="Vabaduse Väljak 3, Tallinn City-Centre, 10141 Tallinn, Estonia", Services = new List<string>{ "residence", "Internet", "Meeting"} },
                new Hotel {City ="Tartu", HotelName ="Hotel Tartu", Adress ="Soola 3, 51013 Tartu, Estonia", Services = new List<string>{ "residence", "Internet", "Meeting"} },
                new Hotel {City ="Tartu", HotelName ="Antonius", Adress ="Ülikooli 15, 51003 Tartu, Estonia ", Services = new List<string>{ "residence", "Family Room",  "Activities"} },
                new Hotel {City ="Pärnu", HotelName ="Hedon Spa & Hotel", Adress ="Ranna Puiestee 1, 80010 Pärnu, Estonia", Services = new List<string>{ "residence",  "Pool", "Activities"} },
                //newnew User {City="Jelena", HotelName =34, Languges = new List<string>{"english", "spanish"} }

            };
            //----------------Students List
            var selectedHotel = from hotel in hotels
                               // from service in hotel.Services
                                select hotel;
            Console.WriteLine("\nNumber\t \tHotels List\n");//\t\t\t \t Servise1 \t\tServise2 \t\tServise3
            Console.WriteLine("\nCity \t \tHotelName \t \tAdress");
            int n = 0;
            foreach (Hotel hotel in selectedHotel)
            {
                n++;
               // Console.WriteLine($"{n}: \t: \t{hotel.City} \t -\t{ hotel.HotelName}\t -\t{ hotel.Adress}\t- \t{hotel.Services[0]}\t - \t{hotel.Services[1]}\t - \t{hotel.Services[2]} ");
 Console.WriteLine($"{n}: \t: \t{hotel.City} \t -\t{ hotel.HotelName}\t -\t{ hotel.Adress} ");
                foreach (var service in hotel.Services)
                {
                    Console.WriteLine("\t"+service+"\t");
                    
                }
            }
            //-------------Hotels List of Tallinn city, sort by hotels name-----------------
             var selectedHotels = from hotel in hotels
                                 	//from name in hotel.HotelName
                                 	//from city in hotel.City

                                 	where hotel.City== "Tallinn"
                                 	//where lang == "english"
                                 	select hotel;
              //--------------------------------------------
                     // var selectedHotels = hotels.Where()           	
              //--------------------------------------------

              Console.WriteLine("\n\nHotels List of Tallinn city, sort by hotels name");

              	Console.WriteLine("\nNumber\t \tCity \t \tHotelName \t \tAdress\t\t\t \t Servise1 \t\tServise2 \t\tServise3 \t\tServise4");
            int j = 0;
            foreach (Hotel hotel in selectedHotels)
            {
                j++;
                Console.Write($"{j}: \t: \t{hotel.City} \t- \t{hotel.HotelName}");
                //foreach (var hotel in hotel.Name)
                //{
                //Console.Write($"\t{city}\t");
                //}
                Console.WriteLine("");

            }/* */
            Console.Write("\n\nPress any key...");
            Console.ReadKey();

        }
    }
}