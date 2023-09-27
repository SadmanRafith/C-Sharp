using System;
namespace lab2task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[5];
            int[] arr2 = new int[5];
            int ct = 0;
            int[] arr3 = new int[10];


            Console.WriteLine("Enter the element of the first array = ");
            for (int i = 0; i < 5; i++)
            {
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Enter the element of the second array = ");
            for (int i = 0; i < 5; i++)
            {
                arr2[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < 5; i++)
            {
                int c = 0;
                if (arr1[i] == 1)
                {
                    continue;
                }
                else if (arr1[i] == 2)
                {
                    arr3[ct] = arr1[i];
                    ct++;
                }
                else
                {
                    for (int j = 2; j < arr1[i]; j++)
                    {
                        if (arr1[i] % j == 0)
                        {
                            c++;
                        }
                    }
                    if (c == 0)
                    {
                        arr3[ct] = arr1[i];
                        ct++;
                    }
                }

            }

            for (int i = 0; i < 5; i++)
            {
                int c = 0;
                if (arr2[i] == 1)
                {
                    continue;
                }
                else if (arr2[i] == 2)
                {
                    arr3[ct] = arr2[i];
                    ct++;
                }
                else
                {
                    for (int j = 2; j < arr2[i]; j++)
                    {
                        if (arr2[i] % j == 0)
                        {
                            c++;
                        }
                    }
                    if (c == 0)
                    {
                        arr3[ct] = arr2[i];
                        ct++;
                    }
                }

            }

            Console.WriteLine("Array of Prime Numbers = ");
            foreach (int i in arr3)
            {
                Console.WriteLine(i);
            }
        }
    }
}