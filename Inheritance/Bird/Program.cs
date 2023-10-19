using System;
using System.Runtime.InteropServices;

class Bird1
{
    public bool fly;

    public Bird1(bool fly)
    {
        this.fly = fly;
    }

    public int canfly(bool fly)
    {
        if (fly == true)
        {
            return 1;
        }
        else
        {
            return 0;
        }

    }
}

class penguin : Bird1
{
    public string color;

    public penguin(string color, bool fly) : base(fly)
    {
        this.color = color;
        canfly(fly);
    }
    public void display_penguin()
    {
        Console.WriteLine("Penguine Information:");
        Console.WriteLine("Color: " + color);
        if (canfly(fly) == 1)
        {
            Console.WriteLine("Bird can fly");
        }
        else
        {
            Console.WriteLine("Bird can't fly");
        }
    }
}

class robin : Bird1
{
    public string color;

    public robin(string color, bool fly) : base(fly)
    {
        this.color = color;
        canfly(fly);
    }
    public void display_robin()
    {
        Console.WriteLine("robin Information:");
        Console.WriteLine("Color: " + color);
        if (canfly(fly) == 1)
        {
            Console.WriteLine("Bird can fly");
        }
        else
        {
            Console.WriteLine("Bird can't fly");
        }
    }
}


namespace Bird
{
    internal class Program
    {
        static void Main(string[] args)
        {
            penguin p1 = new penguin("White & Black", false);
            p1.display_penguin();
            Console.WriteLine();

            robin r1 = new robin("Blue", true); 
            r1.display_robin();

        }
    }
}
