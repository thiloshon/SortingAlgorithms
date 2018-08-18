using DataStructures_Algorithms.Week03;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures_Algorithms.Project01
{
    /// <summary>
    /// Class to sort array with merge sort bottom up method.
    /// </summary>
    public class MergeSortBottomUp : ISorter
    {
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

            int n = array.Length;
            T[] src = array; // alias for the original
            T[] dest = (T[])new T[n]; // make a new temporary array
            T[] temp; // reference used only for swapping

            for (int i = 1; i < n; i *= 2) // each iteration sorts all runs of length i
            {
                for (int j = 0; j < n; j += 2 * i) // each pass merges two runs of length i
                    Merge(src, dest, comparer, j, i);

                temp = src; // reverse roles of the arrays
                src = dest;
                dest = temp;
            }
            if (array != src)
                Array.Copy(src, 0, array, 0, n); // additional copy to get result to original
        }

        /// <summary>
        /// Merges in[start..start+inc−1] and in[start+inc..start+2*inc−1] into out.
        /// </summary>
        /// <typeparam name="T">Generic array is passed.</typeparam>
        /// <param name="inArray">The source array</param>
        /// <param name="outArray">The destination array</param>
        /// <param name="comp">Comparer object to compare elements.</param>
        /// <param name="start">Start intex</param>
        /// <param name="inc">End index</param>
        private void Merge<T>(T[] inArray, T[] outArray, IComparer<T> comp, int start, int inc)
        {
            int end1 = Math.Min(start + inc, inArray.Length); // boundary for run 1
            int end2 = Math.Min(start + 2 * inc, inArray.Length);  // boundary for run 2
            int x = start; // index into run 1
            int y = start + inc; // index into run 2
            int z = start; // index into output

            while (x < end1 && y < end2)
                if (comp.Compare(inArray[x], inArray[y]) < 0)
                    outArray[z++] = inArray[x++]; // take next from run 1
                else
                    outArray[z++] = inArray[y++]; // take next from run 2

            if (x < end1)
                Array.Copy(inArray, x, outArray, z, end1 - x);   // copy rest of run 1      
            else if (y < end2)
                Array.Copy(inArray, y, outArray, z, end2 - y); // copy rest of run 2
        }


    }
}

