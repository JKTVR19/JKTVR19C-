using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello ,world");
            var str = new string('-', 20); //вывести несколько символов.
                Console.WriteLine(str);

            //var hello = new string('Tere, Maailm', 1);
            //-------------------------------------------

            Console.Write("Enter you name");
            string name = Console.ReadLine();
            Console.WriteLine($"Hello, {name}! How are you?");
    Console.WriteLine(str);
            Console.WriteLine("Hellow, " + name + "!");
            //------------------------------numbers
            Console.WriteLine("Enter numbers");
            Console.Write("Enter number 1: ");
            int num1 = Convert.ToInt32 (Console.ReadLine());
            Console.Write("Enter number 2: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            //division
            float result = 0;
            if (num2 == 0)
                {
                Console.WriteLine("division by zero...");
            }else{
                 result = (float)num1 / num2;

                Console.WriteLine($" result: {num1} / {num2} = {result}");
            }
            Console.WriteLine("Result is " + result);


            //------------------------------
            Console.Write("Press any key....");//задержка экрана для просмотра.

            //------------------------------
            Console.ReadKey();

        }
    }
}
