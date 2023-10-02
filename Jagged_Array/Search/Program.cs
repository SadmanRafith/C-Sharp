/*3.	Write a C# program that searches for a specific 
integer in a jagged array and returns its position (row and column) if found. If not found, 
eturn a message indicating that it's not in the array*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] jagged_arr = new int[3][]
                {
             new int[3] {1, 2, 3},
             new int[3] {11, 34, 67},
             new int[3] {89, 23,4}
                };
            int count= 0;

            Console.WriteLine("Enter the element to be searched: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < jagged_arr.Length; i++) 
            { 
               for (int j = 0; j<jagged_arr[i].Length; j++)
                {
                    if (jagged_arr[i][j] == n)
                    {
                        Console.WriteLine($"The searched is found at row{i}, column{j}");
                        count++;
                    }
                }
            }
            if(count==0)
            {
                Console.WriteLine("The searched element not found");
            }
        }
    }
}
