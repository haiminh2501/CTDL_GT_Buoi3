using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSort6Phantu
{
    class Program
    {
        static void Main()
        {
            int[] arr = { 34, 7, 23, 32, 5, 62 };
            Console.WriteLine("Mang truoc khi sap xep:");
            PrintArray(arr);

            QuickSort(arr, 0, arr.Length - 1);

            Console.WriteLine("Mang sau khi sap xep:");
            PrintArray(arr);
            Console.ReadLine();
        }

        static void QuickSort(int[] arr, int low, int high)
        {
            if (low < high)
            {
                int pi = Partition(arr, low, high);

                QuickSort(arr, low, pi - 1);  
                QuickSort(arr, pi + 1, high); 
            }
        }

        static int Partition(int[] arr, int low, int high)
        {
            int pivot = arr[high]; 
            int i = (low - 1);     

            for (int j = low; j < high; j++)
            {
                if (arr[j] < pivot)
                {
                    i++;
                    Swap(arr, i, j);
                }
            }

            Swap(arr, i + 1, high);
            return i + 1;
        }

        static void Swap(int[] arr, int a, int b)
        {
            int temp = arr[a];
            arr[a] = arr[b];
            arr[b] = temp;
        }

        static void PrintArray(int[] arr)
        {
            foreach (int item in arr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }

}
