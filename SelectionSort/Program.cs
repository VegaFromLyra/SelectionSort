using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = {5, 1, 3, 6, 7, 8};

            SelectionSort(input);

            Console.WriteLine("Sorted array is");
            for (int i = 0; i < input.Length; i++)
            {
                Console.Write(input[i] + " ");
            }
        }

        static void SelectionSort(int[] arr)
        {
            int i, j = 0;

            int iMin = 0;

            for (i = 0; i < arr.Length - 1; i++)
            {
                iMin = i;

                for (j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[iMin])
                    {
                        iMin = j;
                    }
                }

                if (iMin != i)
                {
                    int temp = arr[iMin];
                    arr[iMin] = arr[i];
                    arr[i] = temp;
                }
            }
        }
    }
}
