using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApp2
{
    class Program
    {
        //-----------class  student---------
        class Student
        {
            //определим get set
            public string Firstname { get; set; }
            public string Lastname { get; set; }

            public string PersonalID { get; set; }
            public string Group { get; set; }

            private int course;// переменная get
            public int Course
            {
                get { return course; }
                set
                {
                    if (value >= 1 && value <= 5)
                        course = value;
                }
            }
            public string Gender()
            {
                if (PersonalID[0] == '3' || PersonalID[0] == '5')
                    return "male";
                else
                    return "female";
            }
            //вывод на экран
            public override String ToString()
            {
                return "Student: " + Lastname + " " + Firstname + " " + "\n\t\tGroup: " + Group + "Kursus: " + Course + "\n\t\t" + "Gender" + Gender();
            }

        }
            static void Main(string[] args)
        {
                Student student1 = new Student();
                student1.Lastname = "Ivanov";
                student1.Firstname = "Pyotor";
                student1.PersonalID = "39999999999";
                student1.Course = 2;
                Console.WriteLine(student1);
                //-----------------------
                Student student2 = new Student { Lastname = "Kalinina", Firstname = "Tatjana", PersonalID = "4999999999999", Course = 3 };

                Console.WriteLine(student2);
                //------------------

                Console.Write("\n\nPress any key...");
                Console.ReadKey();



        }
    }
}
