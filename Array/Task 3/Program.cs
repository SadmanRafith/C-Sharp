/*Write a program that will take two matrices(3x3) as input. Now show an output that will display a matrix that contains the addition value of the elements of the two matrices*/
using System;

namespace lab1task3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] arr1 = new int[3, 3];
            int[,] arr2 = new int[3, 3];
            int[,] arr3 = new int[3, 3];
            Console.WriteLine("Enter the elements of the first array = ");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    arr1[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("Enter the elements of the second array = ");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    arr2[i, j] = int.Parse(Console.ReadLine());
                }
            }

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    arr3[i, j] = arr1[i, j] + arr2[i, j];
                }
            }
            Console.WriteLine("Addition of two matrix = ");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine(arr3[i, j]);
                }
            }
        }
    }
}
