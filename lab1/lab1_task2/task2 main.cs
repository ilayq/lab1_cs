using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1.lab1_task2
{
    internal class task2
    {
        public static int main(int[,] arr, int[,] arr2)
        {
            
            Console.WriteLine("Sum: ");
            funcs.add(arr, arr2);
            Console.WriteLine("Substract: ");
            funcs.add(arr, arr2, substract: true);
            Console.WriteLine("Multiply:");
            funcs.mupltiply(arr, arr2);
            return 1;
        }

        public static void print_arr(int[,] arr)
        {
            int min = arr[0, 0];
            int max = arr[0, 0];
            int[] min_index = new int[2];
            int[] max_index = new int[2];
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); ++j)
                {
                    Console.Write($"{arr[i, j]} ");
                    if (arr[i, j] < min)
                    {
                        min = arr[i, j];
                        min_index[0] = i;
                        min_index[1] = j;
                    }
                    else
                    {
                        if (arr[i, j] > max)
                        {
                            max = arr[i, j];
                            max_index[0] = i;
                            max_index[1] = j;
                        }
                    }
                }
                Console.Write("\n");
            }
            Console.WriteLine("\n");
            Console.WriteLine($"{max} {max_index[0]} {max_index[1]}");
            Console.WriteLine($"{min} {min_index[0]} {min_index[1]}\n");
            Console.WriteLine("\n");
        }
    }
}
