using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace lab1.lab1_task1
{
    internal class Sort
    {
        private static int temp;
        public static int[] my_sort(int[] arr, bool reverse=false)
        {
            if (reverse)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    for (int j = 0; j < arr.Length - 1; ++j)
                    {
                        if (arr[j] < arr[j+1])
                        {
                            temp = arr[j];
                            arr[j] = arr[j+1];
                            arr[j+1] = temp;
                        }
                    }
                }
            }
            else
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    for (int j = 0; j < arr.Length - 1; ++j)
                    {
                        if (arr[j] > arr[j+1])
                        {
                            temp = arr[j];
                            arr[j] = arr[j+1];
                            arr[j+1] = temp;
                        }
                    }
                }
            }
            return arr;
        }

        public static int[] system_sort(int[] arr, bool reverse = false)
        {
            if (reverse)
            {
                Array.Sort(arr);
                Array.Reverse(arr);
                return arr;
            }
            else { Array.Sort(arr);  return arr; }
        }
    }
}
