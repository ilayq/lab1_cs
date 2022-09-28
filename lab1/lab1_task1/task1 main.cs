using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace lab1.lab1_task1
{
    internal class Task1
    {
        public static int main(int[] arr, string mode)
        {            
            int min;
            int max;
            int min_index;
            int max_index;
            switch (mode)
            {
                case "a":
                    min = arr[0];
                    max = arr[0];
                    max_index = 0;
                    min_index = 0;
                    int even_num_count = 0;
                    for (int i = 0; i<arr.Length; ++i)
                    {
                        Console.Write($"{i} ");
                        if (arr[i] < min)
                        {
                            min = arr[i];
                            min_index = i;
                        }
                        else
                        {
                            if (arr[i] > max)
                            {
                                max = arr[i];
                                max_index = i;
                            }
                        }
                        if (arr[i] % 2 == 0) { even_num_count++; }
                    }
                    Console.Write("\n");
                    Console.WriteLine($"{max} {min} \n");
                    Console.WriteLine($"{max_index} {min_index} \n");
                    foreach (int i in Sort.my_sort(arr))
                    {
                        Console.Write($"{i} ");
                    }
                    Console.WriteLine("\n");
                    foreach (int i in Sort.my_sort(arr, reverse: true))
                    {
                        Console.Write($"{i} ");
                    }
                    Console.WriteLine("\n");
                    int[] even_arr = new int[even_num_count];
                    int even_arr_index = 0;
                    for (int i = 0; i<arr.Length; i++)
                    {
                        if (arr[i] % 2 == 0)
                        {
                            even_arr[even_arr_index] = arr[i];
                            even_arr_index++;
                        }
                    }
                    foreach (int i in even_arr) { Console.Write($"{i} "); }
                    Console.WriteLine("\n");
                    return 1;
                case "b":
                    min = arr[0];
                    max = arr[0];
                    min_index = 0;
                    max_index = 0;
                    even_num_count = 0;
                    for (int i = 0; i < arr.Length; ++i)
                    {
                        Console.Write($"{arr[i]} ");
                        if (arr[i] < min)
                        {
                            min = arr[i];
                            min_index = i;
                        }
                        else
                        {
                            if (arr[i] > max)
                            {
                                max = arr[i];
                                max_index = i;
                            }
                        }
                        if (arr[i] % 2 == 0)
                        {
                            even_num_count++;
                        }
                    }
                    Console.WriteLine("\n");
                    Console.WriteLine($"{max} {max_index} \n");
                    Console.WriteLine($"{min} {min_index} \n");
                    foreach (int i in Sort.system_sort(arr)) { Console.Write($"{i} "); }
                    Console.WriteLine("\n");
                    foreach (int i in Sort.system_sort(arr, reverse: true)) { Console.Write($"{i} "); }
                    Console.WriteLine("\n");
                    even_arr = new int[even_num_count];
                    even_arr_index = 0;
                    for (int i = 0; i<arr.Length; i++)
                    {
                        if (arr[i] % 2 == 0)
                        {
                            even_arr[even_arr_index] = arr[i];
                            even_arr_index++;
                        }
                    }
                    foreach (int i in even_arr) { Console.Write($"{i} "); }
                    Console.WriteLine("\n");
                    return 1;
                default:
                    Console.WriteLine("Режим не выбран, закачиваю работу...");
                    return 0;
            }
        }
    }
}
