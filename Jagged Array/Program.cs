using System;
namespace Jagged_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] jagged_arr = new int[][]
                {
             new int[] {1, 2, 3, 4},
             new int[] {11, 34, 67},
             new int[] {89, 23},
             new int[] {0, 45, 78, 53, 99}
                  };
            Console.WriteLine(jagged_arr[2][0]);
        }
      
    }
}
