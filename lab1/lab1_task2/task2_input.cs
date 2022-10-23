using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace lab1.lab1_task2
{
    internal class task2_input
    {
        public static int main()
        {
            Console.WriteLine("Write input type: ");
            string inp_type = Console.ReadLine();
            if (inp_type != "kb" && inp_type != "fl") { Console.WriteLine("Wrong input type"); return 0; }
            switch (inp_type) {
                case "kb":
                    Console.WriteLine("Write matrix size:");
                    string[] size = Console.ReadLine().Split();
                    int columns1, rows1 = 0;
                    if (Int32.TryParse(size[1], out columns1) && Int32.TryParse(size[0], out rows1))
                    {

                    }
                    else
                    {
                        Console.WriteLine("Wrong input");
                        return 0;
                    }
                    int[,] arr = new int[rows1, columns1];
                    string[] row;
                    Console.WriteLine("Write matrix:");
                    for (int i = 0; i < rows1; i++)
                    {
                        row = Console.ReadLine().Split();
                        for (int j = 0; j < columns1; ++j)
                        {
                            //arr[i, j] = Convert.ToInt32(row[j]);
                            if (!(int.TryParse(row[j], out arr[i, j]))) { Console.WriteLine("Wrong arr input"); return 0; }
                        }
                    }
                    Console.WriteLine("\n");
                    task2.print_arr(arr);
                    Console.WriteLine("Write size of second matrix");
                    string[] size2 = Console.ReadLine().Split();
                    int columns2, rows2;
                    if (!(int.TryParse(size2[0], out rows2) && int.TryParse(size2[1], out columns2))) { return 0; }
                    int[,] arr2 = new int[rows2, columns2];
                    string[] row2;
                    Console.WriteLine("Write second matrix");
                    for (int i = 0; i < rows2; i++)
                    {
                        row2 = Console.ReadLine().Split();
                        for (int j = 0; j < columns2; ++j)
                        {
                            if (!(int.TryParse(row2[j], out arr2[i, j]))) { return 0; }
                        }
                    }
                    return task2.main(arr, arr2);
                case "fl":
                    string[] lines = System.IO.File.ReadAllLines(@"t2_input.txt");
                    size = lines[0].Split();
                    columns1 = 0;
                    if (int.TryParse(size[0], out rows1) && int.TryParse(size[1], out columns1) == false) { return 0; }
                    arr = new int[rows1, columns1];
                    for (int i = 1; i <= rows1; i++)
                    {
                        row = lines[i].Split();
                        for (int j = 0; j < columns1; ++j)
                        {
                            if (int.TryParse(row[j], out arr[i-1, j])) { } else { return 0; }
                        }
                    }
                    task2.print_arr(arr);
                    size2 = lines[rows1+1].Split();
                    columns2 = 0;
                    if (int.TryParse(size2[0], out rows2) && int.TryParse(size2[1], out columns2) == false) { return 0; }
                    arr2 = new int[rows2, columns2];
                    for (int i = rows1+2; i <= rows2 + 3; i++)
                    {
                        row = lines[i].Split();
                        for (int j = 0; j < columns2; j++)
                        {
                            if (int.TryParse(row[j], out arr2[i - rows1 - 2, j])) { continue; }
                            else
                            {
                                Console.WriteLine("wrong second matrix");
                                return 0;
                            }
                        }
                    }
                    return task2.main(arr, arr2);
                default:
                    Console.WriteLine("wrong input type");
                    return 0;
            }
        }
    }
}