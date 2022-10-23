using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace lab1.lab1_task1
{
    internal class task1_inp
    {
        public static int main()
        {
            Console.WriteLine("Choose input type:");
            string input_type = Console.ReadLine();
            string mode = "";
            switch (input_type)
            {
                case "kb":
                    Console.WriteLine("Choose the mode(a, b):\n");
                    mode = Console.ReadLine();
                    while (mode != "a" && mode != "b")
                    {
                        Console.WriteLine("wrong mode, try again");
                        mode = Console.ReadLine();
                    }
                    
                        string[] input = Console.ReadLine().Split(' ');
                        int[] arr = new int[input.Length];
                        for (int i = 0; i < arr.Length; i++)
                        {
                            if (int.TryParse(input[i], out arr[i]))
                            {

                            }
                            else
                            {
                                Console.WriteLine("Wrong array");
                                return 0;
                            }
                        }
                        Task1.main(arr, mode);
                        return 1;
                case "fl":
                    string[] lines = System.IO.File.ReadAllLines("t1_input.txt");
                    mode  = lines[0];
                    if (mode != "a" && mode != "b") { Console.WriteLine("Wrong mode"); return 0; }
                    arr = new int[lines[1].Split().Length];
                    int c = 0;
                    foreach (string i in lines[1].Split())
                    {
                        if (int.TryParse(i, out arr[c])) { c++; } else { Console.WriteLine("Wrong array"); return 0; }
                    }
                    return Task1.main(arr, mode);           
                default:
                    Console.WriteLine("Wrong type of input, try again");
                    return 0;
            }
        }
    }
}
