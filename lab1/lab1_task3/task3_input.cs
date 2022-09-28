using System;
using System.Collections.Generic;
using System.Data.Common.CommandTrees.ExpressionBuilder;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1.lab1_task3
{
    internal class task3_input
    {
        public static int main()
        {
            Console.WriteLine("Write type of input:");
            string input_type = Console.ReadLine();
            switch (input_type)
            {
                case "kb":
                    Console.WriteLine("Write number of rows");
                    int rows;
                    if (!(int.TryParse(Console.ReadLine(), out rows))) { Console.WriteLine("Wrong number of rows"); return 0; }
                    int[][] arr = new int[rows][];
                    string[][] input = new string[rows][];
                    for (int i = 0; i < rows; i++)
                    {
                        input[i] = Console.ReadLine().Split();
                    }
                    Console.WriteLine("\n");
                    for (int i = 0; i<input.Length; i++)
                    {
                        arr[i] = new int[input[i].Length];
                    }
                    for (int i = 0; i<rows; i++)
                    {
                        for (int j = 0; j < input[i].Length; j++)
                        {
                            if (int.TryParse(input[i][j], out arr[i][j]))
                            {

                            }
                            else
                            {
                                Console.WriteLine("Wrong array");
                                return 0;
                            }
                        }
                    }
                    Console.WriteLine("write indexes of el u need to change");
                    string str_index = Console.ReadLine();
                    return task3.main(arr, str_index);
                case "fl":
                    string[] lines = System.IO.File.ReadAllLines("t3_input.txt");
                    if (!(int.TryParse(lines[0], out rows))) { return 0; }
                    input = new string[rows][];
                    arr = new int[rows][];
                    for (int i = 1; i <= rows; i++)
                    {
                        input[i-1] = lines[i].Split();
                        arr[i-1] = new int[input[i-1].Length];
                    }
                    Console.WriteLine("\n");
                    for (int i = 0; i<rows; i++)
                    {
                        for (int j = 0; j < input[i].Length; j++)
                        {
                            if (int.TryParse(input[i][j], out arr[i][j]))
                            {
                            }
                            else
                            {
                                Console.WriteLine("Wrong array");
                                return 0;
                            }
                        }
                    }
                    str_index = lines[lines.Length - 1];
                    return task3.main(arr, str_index);
                default:
                    Console.WriteLine("Wrong type of input");
                    return 0;
            }
        }
    }
}
