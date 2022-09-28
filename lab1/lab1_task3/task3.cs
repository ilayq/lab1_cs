using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;


namespace lab1.lab1_task3
{
    internal class task3
    {
        public static int main(int[][] arr, string indexes)
        {
            int min = arr[0][0];
            int max = arr[0][0];
            int[] min_index = new int[2];
            int[] max_index = new int[2];
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr[i].Length; ++j)
                {
                    Console.Write($"{arr[i][j]} ");
                    if (arr[i][j] < min)
                    {
                        min_index[0] = i;
                        min_index[1] = j;
                        min = arr[i][j];
                    }
                    else
                    {
                        if (arr[i][j] > max)
                        {
                            max_index[0] = i;
                            max_index[1] = j;
                            max = arr[i][j];
                        }
                    }
                }
                Console.Write("\n");
            }
            Console.WriteLine("\n");
            Console.WriteLine($"{max} {max_index[0]} {max_index[1]}");
            Console.WriteLine($"{min} {min_index[0]} {min_index[1]}\n\n");
            int[] index = new int[indexes.Split().Length];
            for (int i = 0; i<index.Length; i++)
            {
                if (int.TryParse(indexes.Split()[i], out index[i]))
                {

                }
                else
                {
                    Console.WriteLine("Wrong indexes");
                    return 0;
                }
            }
            Random r = new Random();
            int number = r.Next();
            arr[index[0]][index[1]]= number;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr[i].Length; ++j)
                {
                    Console.Write($"{arr[i][j]} ");
                }
                Console.Write("\n");
            }
            return 1;
        }
    }
}
