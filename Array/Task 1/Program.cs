using System;

namespace Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of elements in the array: ");
            int n= int.Parse(Console.ReadLine());

            int[] num= new int[n];

            Console.WriteLine("Enter the elements of the array: ");

            for(int i=0; i<n; i++)
            {
                num[i] = int.Parse(Console.ReadLine());
            }

            int small = num[0];
            int large = num[0];

            foreach(int i in num)
            {
                if(i<small)
                {
                    small = i;
                }

                if (i > large)
                {
                    large = i;
                }
            }
            Console.WriteLine($"Largest Number: {large}");
            Console.WriteLine($"Smallest Number: {small}");
            Console.ReadLine();
        }
    }
}
