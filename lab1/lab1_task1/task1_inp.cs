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
                    using (FileStream file = File.OpenRead("t1_input.txt"))
                    {
                        byte[] data = new byte[file.Length];
                        file.Read(data, 0, data.Length);
                        string[] text = System.Text.Encoding.Default.GetString(data).Split('\n');
                        for (int i = 0; i < text[0].Length; i++)
                        {
                            if (text[0][i] == 'b' || text[0][i] == 'a')
                            {
                                mode = Convert.ToString(text[0][i]);
                            }
                        }
                        if (mode.Length == 0) { return 0; }
                        if (mode == "a" || mode == "b")
                        {
                            arr = new int[text[1].Split(' ').Length];
                            for (int i = 0; i < text[1].Split(' ').Length; i++)
                            {
                                if (int.TryParse(text[1].Split(' ')[i], out arr[i]))
                                {

                                }
                                else
                                {
                                    Console.WriteLine("Wrong number");
                                    return 0;
                                }
                            }
                            Task1.main(arr, mode);
                            return 1;
                        }
                        else
                        {
                            Console.WriteLine("Wrong mode");
                            return 0;
                        }
                    }                       
                default:
                    Console.WriteLine("Wrong type of input, try again");
                    return 0;
            }
        }
    }
}
