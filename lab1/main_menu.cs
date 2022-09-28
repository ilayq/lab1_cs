using lab1.lab1_task1;
using lab1.lab1_task2;
using lab1.lab1_task3;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    internal class main_menu
    {
        public static int main()
        {
            Console.WriteLine("Choose the task");
            int st;
            string task = Console.ReadLine();
            switch (task)
            {
                case "t1":
                    st = task1_inp.main();
                    while (st == 0)
                    {
                        st = task1_inp.main();
                    }
                    return 1;
                case "t2":
                    st = task2_input.main();
                    while (st == 0)
                    {
                        st = task2_input.main();
                    }
                    return 1;
                case "t3":
                    st = task3_input.main();
                    while (st == 0)
                    {
                        st = task3_input.main();
                    }
                    return 1;
                case "exit":
                    Process.GetCurrentProcess().Kill();
                    return 0;
                default:
                    Console.WriteLine("Wrong task");
                    main_menu.main();
                    return 0;
            }
        }   
    }
}
