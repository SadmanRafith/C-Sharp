using System;
using System.Net.NetworkInformation;

class Human
{
    protected string Organ;

    public Human(string organ)
    {
        this.Organ = organ;
    }
}

class Student : Human
{
    public int id;
    public float cgpa;

    public Student(int id, float cgpa, string organ):base(organ)
    {
        this.id = id;
        this.cgpa = cgpa;
    }
    public void display()
    {
        Console.WriteLine("Student Id: " + id);
        Console.WriteLine("Cgpa: " + cgpa);
        Console.WriteLine("Organ: " + Organ);
    }
}

class ExStudent : Student
{
    public string Year;

    public ExStudent(int id, float cgpa, string year, string organ) : base(id,cgpa,organ)
    {
       this.Year = year;
    }

    public void display_ex_Student()
    {
        Console.WriteLine("Student Id: " + id);
        Console.WriteLine("Cgpa: " + cgpa);
        Console.WriteLine("Graduated Year: "+Year);
        Console.WriteLine("Organ: " + Organ);
    }
}

class Teacher : Human
{
    public string name;
    public string dept;

    public Teacher(string name, string dept, string organ) : base(organ)
    {
        this.name = name;
        this.dept = dept;
    }

    public void teacher_display()
    {
        Console.WriteLine("Teacher Name: " + name);
        Console.WriteLine("Department: " + dept);
        Console.WriteLine("Organ: " + Organ);
    }
}


namespace First_class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student(02, 3.5f, "Heart");
            s1.display();
            Console.WriteLine();

            ExStudent e1 = new ExStudent(03, 3.75f, "2020", "Heart");
            e1.display_ex_Student();
            Console.WriteLine();

            Teacher t1 = new Teacher("Kabir", "CSE", "Liver");
            t1.teacher_display();
        }
    }
}
