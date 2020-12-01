using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentListApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "Ivanov", "Ivanova", "Petrov", "Pavlov", "Djatlov", "Sidorov", "Abramov", "Kirov", "Svetlov", "Aronova", "Akulov", };
            //--------------------------------
            Console.WriteLine("\n\nVariant 1. Array");
            var selectedNames = new List<string>();
            foreach (string s in names)
            {
                if (s.ToUpper().StartsWith("A"))// find in start line
                    selectedNames.Add(s);
            }
            selectedNames.Sort();//sort
            //output
            foreach (string s in selectedNames)
            {
                Console.WriteLine(s);
            }

            //------------------------2 Variant LINQ
            Console.WriteLine(string.Concat(Enumerable.Repeat("=", 20)));
            //----------------------
            Console.WriteLine("\n\nVariant 2. LINQ");
            //Find lastnames were start "A"
            var namesA = from n in names
                         where n.StartsWith("A")
                         orderby n //sort in higher
                         select n;
            //output
            foreach (string item in namesA)
            {
                Console.WriteLine(item);
            }
            //------------------------------
            Console.Write("\n\nPress any key...");
            Console.ReadKey();
        }
    }
}
