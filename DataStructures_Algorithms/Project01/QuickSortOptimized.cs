using DataStructures_Algorithms.Week03;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures_Algorithms.Project01
{

    /// <summary>
    /// Class to sort array with Randomized Quick sort in memory optimized stack method.
    /// </summary>
    public class QuickSortOptimized : ISorter
    {
        private Random random = new Random();

        /// <summary>
        /// Sorts the generic array using the comparer passed in stacks.
        /// Decreasing or increasing order is governed by the comparer.
        /// </summary>
        /// <typeparam name="T">Generic array is passed but should be an implementation of IComparable interface.</typeparam>
        /// <param name="array">The array to be sorted. A generic array.</param>
        /// <param name="comparer">The comparer object to use in sorting. If null is passed, default comparer will be created.</param>
        public void Sort<T>(T[] array, IComparer<T> comparer) where T : IComparable<T>
        {
            if (comparer == null) comparer = Comparer<T>.Default;
            QuickSortIterative(array, 0, array.Length - 1, comparer);
        }


        /// <summary>
        /// Internal method to sort in stack implementation.
        /// </summary>
        /// <typeparam name="T">Generic array is passed</typeparam>
        /// <param name="arr">Array to be sorted</param>
        /// <param name="l">Starting index</param>
        /// <param name="h">Ending index</param>
        /// <param name="comparer">Comparer object to compare elements.</param>
        private void QuickSortIterative<T>(T[] arr, int l, int h, IComparer<T> comparer)
        {
            int[] stack = new int[h - l + 1]; // Create an auxiliary stack
            int top = -1; // initialize top of stack            
            stack[++top] = l; // push initial values of l and h to 
            stack[++top] = h; // stack

            while (top >= 0) // Keep popping from stack while is not empty
            {
                h = stack[top--]; // Pop h and l
                l = stack[top--];
                int p = Partition(arr, l, h, comparer); // Set pivot element at its correct position in sorted array

                if (p - 1 > l)
                { // If there are elements on left side of pivot, then push left side to stack
                    stack[++top] = l;
                    stack[++top] = p - 1;
                }

                if (p + 1 < h)
                { // If there are elements on right side of pivot, then push right side to stack
                    stack[++top] = p + 1;
                    stack[++top] = h;
                }
            }
        }


        /// <summary>
        /// This function takes last element as pivot, places the pivot element at its correct
        /// position in sorted array, and places all smaller (smaller than pivot) to left of
        /// pivot and all greater elements to right of pivot   
        /// </summary>
        /// <typeparam name="T">Generic array is passed</typeparam>
        /// <param name="arr">Array to be partitioned</param>
        /// <param name="low">Starting index</param>
        /// <param name="high">Ending index</param>
        /// <param name="comparer">Comparer object to compare elements.</param>
        /// <returns></returns>
        private int Partition<T>(T[] arr, int low, int high, IComparer<T> comparer)
        {
            //  randomized pivot point optimization
            int randomIndex = random.Next(low, high);
            Swap(ref arr[randomIndex], ref arr[high]);

            T pivot = arr[high];
            int i = (low - 1); // index of smaller element
            for (int j = low; j <= high - 1; j++)
            {
                if (comparer.Compare(arr[j], pivot) <= 0)
                { // If current element is smaller than or equal to pivot          
                    i++;
                    Swap<T>(ref arr[i], ref arr[j]); // swap arr[i] and arr[j]
                }
            }

            Swap<T>(ref arr[i + 1], ref arr[high]); // swap arr[i+1] and arr[high] (or pivot)
            return i + 1;
        }


        /// <summary>
        /// Internal function to swap elements
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t1"></param>
        /// <param name="t2"></param>
        private void Swap<T>(ref T t1, ref T t2)
        {
            T tmp = t2;
            t2 = t1;
            t1 = tmp;
        } 
    }
}
