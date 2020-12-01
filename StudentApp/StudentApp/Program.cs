using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApp
{
    class Program

    {
        //-----------class  student---------
        class Student
        {
            //определим переменные
            public string firstname;
            public string lastname;
            public string group;
            //-------variant

            public Student()//constuctor - set data METOD
            {

            }
            //-----Variant 2
            public Student(string fName, string lastname)
            {
                this.firstname = fName;
                this.lastname = lastname;
                this.group = "JKTVR20";
            }
            public Student(string fName, string lastname, string gr)
            {
                this.firstname = fName;
                this.lastname = lastname;
                group = gr;
            }
            //data set 

            //data output
            public void Getinfo()
            {
                Console.WriteLine($"Student: {firstname} {lastname}, Group {group}");

            }

        }

        static void Main(string[] args)
        {
            //variant 1
            //declare class
            Student stud = new Student();
            //properties
            stud.firstname = "Anne";
            stud.lastname = "Ivanova";
            stud.group = "JKTVR19";
            Console.WriteLine("Variant1");
            stud.Getinfo();
            //-----------Variant2
            Console.WriteLine("Variant2");

            Student stud2 = new Student("Jelena","Sokolova");
            stud2.Getinfo();

            Student stud3 = new Student("Sergei", "Petrov");
            stud3.Getinfo();

            // -----------Variant3
            Console.WriteLine("Variant3");

            Student stud4 = new Student("JKaterina", "Dimova", "JPTVR18");
            stud4.Getinfo();

            //----------
            Console.Write("\n\nPress any key...");
            Console.ReadKey();
        }
    }
}
