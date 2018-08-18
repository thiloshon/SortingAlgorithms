using DataStructures_Algorithms.Week03;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures_Algorithms.Project01
{
    /// <summary>
    /// Class to sort array with merge sort top down method.
    /// </summary>
    public class MergeSortTopDown : ISorter
    {
        /// <summary>
        /// Sorts the generic array using the comparer passed in recursion.
        /// Decreasing or increasing order is governed by the comparer.
        /// </summary>
        /// <typeparam name="T">Generic array is passed but should be an implementation of IComparable interface.</typeparam>
        /// <param name="array">The array to be sorted. A generic array.</param>
        /// <param name="comparer">The comparer object to use in sorting. If null is passed, default comparer will be created.</param>
        public void Sort<T>(T[] array, IComparer<T> comparer) where T : IComparable<T>
        {
            if (comparer == null) comparer = Comparer<T>.Default;
            int n = array.Length;
            int mid = n / 2;

            if (n < 2) return; // array is trivially sorted

            // Partition 
            T[] s1 = array.Take(n / 2).ToArray(); // copy of first half
            T[] s2 = array.Skip(n / 2).ToArray(); // copy of second half

            // Recursion
            Sort(s1, comparer); // sort copy of first half
            Sort(s2, comparer); // sort copy of second half

            // Combination
            Merge(s1, s2, array, comparer); // merge sorted halves back into original
        }

        /// <summary>
        /// Internal method to merge contents of arrays S1 and S2 into properly sized array S.
        /// </summary>
        /// <typeparam name="T">Generic array is passed.</typeparam>
        /// <param name="leftArray">The first array to merge.</param>
        /// <param name="rightArray">The second array to merge</param>
        /// <param name="array">Array to be merged into.</param>
        /// <param name="comparer">Comparer object to compare elements.</param>
        private void Merge<T>(T[] leftArray, T[] rightArray, T[] array, IComparer<T> comparer)
        {
            int i = 0;
            int j = 0;

            while (i + j < array.Length)
            {
                if (j == rightArray.Length || (i < leftArray.Length && comparer.Compare(leftArray[i], rightArray[j]) < 0))
                    array[i + j] = leftArray[i++]; // copy ith element of S1 and increment i
                else
                    array[i + j] = rightArray[j++]; // copy jth element of S2 and increment j
            }
        }
    }
}
