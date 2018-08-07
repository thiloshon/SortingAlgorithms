using DataStructures_Algorithms.Week03;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Runner.Data.Project01
{
    public class QuickSortOptimized : ISorter
    {
        private Random random = new Random();

        public void Sort<T>(T[] array, IComparer<T> comparer) where T : IComparable<T>
        {
            quickSortIterative(array, 0, array.Length -1, comparer);
        }



        /* A[] --> Array to be sorted, 
    l --> Starting index, 
    h --> Ending index */
        static void quickSortIterative<T>(T[] arr,
                                     int l, int h, IComparer<T> comparer)
        {
            // Create an auxiliary stack
            int[] stack = new int[h - l + 1];

            // initialize top of stack
            int top = -1;

            // push initial values of l and h to 
            // stack
            stack[++top] = l;
            stack[++top] = h;

            // Keep popping from stack while 
            // is not empty
            while (top >= 0)
            {
                // Pop h and l
                h = stack[top--];
                l = stack[top--];

                // Set pivot element at its 
                // correct position in 
                // sorted array
                int p = partition(arr, l, h, comparer);

                // If there are elements on 
                // left side of pivot, then
                // push left side to stack
                if (p - 1 > l)
                {
                    stack[++top] = l;
                    stack[++top] = p - 1;
                }

                // If there are elements on
                // right side of pivot, then 
                // push right side to stack
                if (p + 1 < h)
                {
                    stack[++top] = p + 1;
                    stack[++top] = h;
                }
            }
        }


        /* This function takes last element as pivot,
    places the pivot element at its correct
    position in sorted array, and places all
    smaller (smaller than pivot) to left of
    pivot and all greater elements to right
    of pivot */
        static int partition<T>(T[] arr, int low,
                                       int high, IComparer<T> comparer)
        {
            T temp;
            T pivot = arr[high];

            // index of smaller element
            int i = (low - 1);
            for (int j = low; j <= high - 1; j++)
            {
                // If current element is smaller
                // than or equal to pivot
                if (comparer.Compare(arr[j], pivot) <= 0)
                {
                    i++;

                    // swap arr[i] and arr[j]
                    temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }

            // swap arr[i+1] and arr[high] 
            // (or pivot)

            temp = arr[i + 1];
            arr[i + 1] = arr[high];
            arr[high] = temp;

            return i + 1;
        }     
    }
}
