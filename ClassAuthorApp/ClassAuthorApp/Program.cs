using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System;
//using System.Linq;

namespace ClassAuthorApp
{
    class Program
    {
        public class Author
        {
            //public string Fistname { get; set; }
            public string Lastname { get; set; }
            public string Firstname { get; set; }

            public override string ToString()
            {
                return "Author: " + Firstname + " " + Lastname;
            }

        }
        static void Main(string[] args)
        {
            // Array authors
            Author[] authors ={

            new Author {Firstname="Dino", Lastname="Esposito"},
            new Author {Firstname="James", Lastname="Gosling"}
            };

            //-----------------------------
            Console.WriteLine("\n\nVariant 1. Loop Operator : FOR");
            for (int i = 0; i < authors.Length; i++)
            {
                Console.WriteLine((i + 1) + "." + authors[i]);

            }
            Console.WriteLine(string.Concat(Enumerable.Repeat("=", 20)));
            //----------------
            Console.WriteLine("\n\nVariant 2. Loop Operator : FOR");
            int n = 0;
            foreach (Author author in authors)
            {
                n++;
                Console.WriteLine(n + ". " + author);
            }
            Console.Write("\n\nPress any key...");
            Console.ReadKey();
        }
    }
}
    

