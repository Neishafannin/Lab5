using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    class Program
    {
        
        public static void Main(string[] args)
        {
            string isEverythingCorrect = "N";

            while (isEverythingCorrect != "Y")
            {
                AskForInfo();

                System.Console.WriteLine("Is everything correct (Y/N) ?");
                isEverythingCorrect = System.Console.ReadLine().ToUpper();
            }
            

            System.Console.WriteLine("Press any key to exit");
            System.Console.ReadKey();
        }


        public static void AskForInfo()  //organized code using this static method 
        {
            Course course = new Course();

            System.Console.WriteLine("What is the name of your course?");
            course.name = System.Console.ReadLine();

            System.Console.WriteLine("What is your course number?");
            course.crnNumber = int.Parse(System.Console.ReadLine());

            System.Console.WriteLine("How many students are in the course?");
            int numStudents = int.Parse(System.Console.ReadLine());

            course.students = new Student[numStudents];

            for (int i = 0; i < numStudents; i++)
            {
                Student student = new Student();

                System.Console.WriteLine("What is student " + (i + 1) + " name?");
                student.name = System.Console.ReadLine();

                System.Console.WriteLine("What is student " + (i + 1) + " S-Number?");
                student.sNumber = System.Console.ReadLine();

                course.students[i] = student;
            }

            System.Console.WriteLine("This is your course name:" + course.name);
            System.Console.WriteLine("This is your course number:" + course.crnNumber);

            for (int i = 0; i < numStudents; i++)
            {
                System.Console.WriteLine("Student " + (i + 1) + " Name: " + course.students[i].name);
                System.Console.WriteLine("Student " + (i + 1) + " S Number: " + course.students[i].sNumber);

            }

        }

    }
}
