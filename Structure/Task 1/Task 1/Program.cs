using System;

struct student
{
    public int id;
    public int semesterCmplt;
    public int creditCmplt;
    public double CGPA;
}
namespace Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            student[] studentrecords = new student[2];

            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine($"Enter the information of Student Number {i+1}");
                student student = new student();
                Console.Write("Enter Unique id: ");
                student.id = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter Semester Completed: ");
                student.semesterCmplt = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter Number of credits completed: ");
                student.creditCmplt = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter CGPA:  ");
                student.CGPA= Convert.ToDouble(Console.ReadLine());

                Console.WriteLine();

                studentrecords[i] = student;
                if (student.CGPA >= 3.75)
                {
                    Console.WriteLine($"Student of id {student.id} is a scholarship student");
                }

                if (student.creditCmplt > 50)
                {
                    Console.WriteLine($"Student of id {student.id} has completed more than 50 credits");
                }

                if (student.semesterCmplt >= 2 && student.creditCmplt >= 28)
                {
                    Console.WriteLine($"Student of id {student.id} has completde minimum 2 semester and minimum 28 credits");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
