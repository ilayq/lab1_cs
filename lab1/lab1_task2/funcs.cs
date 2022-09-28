using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace lab1.lab1_task2
{
    internal class funcs
    {
        public static void add(int[,] arr1, int[,] arr2, bool substract = false)
        {
            if (arr1.GetLength(0) != arr2.GetLength(0) || arr1.GetLength(1) != arr2.GetLength(1))
            {
                Console.WriteLine("Операция Add недопустима!");
            }
            else
            {
                if (!substract)
                {
                    int result;
                    for (int i = 0; i < arr1.GetLength(0); i++)
                    {
                        for (int j = 0; j < arr1.GetLength(1); j++)
                        {
                            result = arr1[i, j] + arr2[i, j];
                            Console.Write($"{result} ");
                        }
                        Console.WriteLine("\n");
                    }
                }
                else
                {
                    int result;
                    for (int i = 0; i < arr1.GetLength(0); i++)
                    {
                        for (int j = 0; j < arr1.GetLength(1); j++)
                        {
                            result = arr1[i, j] - arr2[i, j];
                            Console.Write($"{result} ");
                        }
                        Console.WriteLine("\n");
                    }
                }
            }

        }

        private static int mult_arrays(int[] arr1, int[] arr2)
        {
            int result = 0;
            for (int i = 0; i < arr1.Length; i++)
            {
                result += arr1[i] * arr2[i];
            }
            return result;
        }

        private static int[] get_column(int[,] arr, int column)
        {
            int[] result = new int[arr.GetLength(0)];
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                result[i] = (int)arr[i, column];
            }
            return result;
        }

        private static int[] get_row(int[,] arr, int row)
        {
            int[] result = new int[arr.GetLength(1)];
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                if (i == row)
                {
                    for (int j = 0; j < arr.GetLength(1); j++)
                    {
                        result[j] = arr[i, j];
                    }
                }
                else
                {
                    continue;
                }
            }
            return new int[1] { 0 };
        }
        public static void mupltiply(int[,] arr1, int[,] arr2)
        {
            int[,] result = new int[arr1.GetLength(0), arr2.GetLength(1)];
            if (arr1.GetLength(1) != arr2.GetLength(0))
            {
                Console.WriteLine("Операция Multiply невозможна!");
                if (arr2.GetLength(1) == arr1.GetLength(0))
                {
                    Console.WriteLine("Умножаю матрицы в обратном порядке:");
                    funcs.mupltiply(arr2, arr1);
                }
            }
            else
            {
                for (var i = 0; i < result.GetLength(0); i++)
                {
                    for (int j = 0; j < result.GetLength(1); j++)
                    {
                        result[i, j] = mult_arrays(get_row(arr1, i), get_column(arr2, j));
                    }
                }
                for (var i = 0; i < result.GetLength(0); i++)
                {
                    for (var j = 0; j < result.GetLength(1); j++)
                    {
                        Console.WriteLine($"{result[i, j]} ");
                    }
                    Console.WriteLine("\n");
                }
            }
        }
    }
}
