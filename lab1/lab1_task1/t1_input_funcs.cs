using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.InteropServices.WindowsRuntime;

namespace lab1.lab1_task1
{
    internal class t1_input_funcs
    {
        public static string input_mode(string input_type)
        {
            switch (input_type) {
                case "kb":
                    string mode = Console.ReadLine();
                    while (mode != "a" || mode != "b") {
                        Console.WriteLine("wrong mode, try again");
                        mode = Console.ReadLine();
                    }
                    return mode;
                case "fl":
                    string[] lines = System.IO.File.ReadAllLines("t1_input.txt");
                    mode = lines[0];
                    while (mode != "a" || mode != "b")
                    {
                        Console.WriteLine("Wrong mode, trying again...");
                        mode = lines[0];
                    }
                    return mode;
                default:
                    Console.WriteLine("Wrong input type");
                    return "Wrong input type";
            }
        }
    }
}
