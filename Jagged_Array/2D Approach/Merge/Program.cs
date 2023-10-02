using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] jagged_arr1 = new int[3][]
                {
             new int[3] {1, 2, 3},
             new int[3] {11, 34, 67},
             new int[3] {89, 23,4}
                };

            int[][] jagged_arr2 = new int[3][]
                {
             new int[3] {11, 22, 33},
             new int[3] {1, 4, 6},
             new int[3] {8, 2,42}
                };

            int[][] merge_arr = new int[jagged_arr1.Length + jagged_arr2.Length][];

            for (int i = 0; i < jagged_arr1.Length; i++)
            {
                merge_arr[i] = new int[jagged_arr1.Length];
                for(int j = 0; j<jagged_arr1.Length; j++)
                {
                    merge_arr[i][j] = jagged_arr1[i][j];
                }
            }

            for (int i = 0;i < jagged_arr2.Length; i++)
            {
                merge_arr[jagged_arr1.Length+i] =  new int[jagged_arr2.Length];
                {
                    for(int j = 0;j<jagged_arr2.Length;j++)
                    {
                        merge_arr[jagged_arr1.Length + i][j] = jagged_arr2[i][j];
                    }
                }
            }

            Console.WriteLine("Merged Array: ");
            for (int i = 0; i < merge_arr.Length; i++)
            {
                for (int j = 0; j < merge_arr[i].Length; j++)
                {
                    Console.Write(merge_arr[i][j] + " ");
                }
                
            }

        }
    }
}
