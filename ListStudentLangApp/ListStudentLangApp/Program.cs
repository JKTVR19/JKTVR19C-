using System;
using System.Collections.Generic;
using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace ListStudentLangApp
{
    class Program
    {
        class User
        {
            public string Name { get; set; }
            public int Age { get; set; }
            public IList<string> Languges { get; set; }
            public User()
            {
                Languges = new List<string>();
            }
        }
        static void Main(string[] args)
        {
            List<User> users = new List<User>
            {
                new User {Name="Ivan", Age =23, Languges = new List<string>{"english", "german"} },
                new User {Name="Alex", Age =27, Languges = new List<string>{"english", "french"} },
                new User {Name="Maria", Age =29, Languges = new List<string>{"english", "spanish"} },
                new User {Name="Jelena", Age =34, Languges = new List<string>{"english", "spanish"} },

            };
            //----------------Students List
            var selectedPerson = from user in users
                                  select user;
            Console.WriteLine("\n\nStudents List\n");
            Console.WriteLine("\nName \t \tAge \t Languge1 \tLanguge2");
            foreach (User user in selectedPerson)
            {
                Console.WriteLine($"{ user.Name} \t -\t{ user.Age} \t{ user.Languges[0]} - \t{ user.Languges[1]}");
            }
            //-------------Students List Learned english and older 25 years------------------
            var selectedUsers = from user in users
                                from lang in user.Languges
                                where user.Age > 25
                                where lang == "english"
                                select user;
            Console.WriteLine("\n\nStudents list (English)");
            Console.WriteLine("\nName \t \tAge \t Langige1 \tLanguge2");
            foreach (User user in selectedUsers)
            {
                Console.Write($"{user.Name} \t- \t{user.Age}");
                    foreach (var lang in user.Languges)
                {
                    Console.Write($"\t{lang}\t");
                }
                Console.WriteLine("");

            }
            Console.Write("\n\nPress any key...");
            Console.ReadKey();

        }
    }
}
