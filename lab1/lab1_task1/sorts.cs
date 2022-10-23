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

        public static int[] qsort(int[] array)
        {
            if (array.Length <= 1) { return array; }
            
            Random x = new Random();
            int mid = array[x.Next() % array.Length];
            int[] lower_equal = {}, upper = {}, temp = {};
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] <= mid)
                {
                    temp = lower_equal;
                    lower_equal = new int[lower_equal.Length + 1];
                    temp.CopyTo(lower_equal, 0);
                    lower_equal[lower_equal.Length - 1] = array[i];
                }
                else
                {
                    temp = upper;
                    upper = new int[upper.Length + 1];
                    temp.CopyTo(upper, 0);
                    upper[upper.Length - 1] = array[i];
                }
            }
            return qsort(lower_equal).Concat(qsort(upper)).ToArray();
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
