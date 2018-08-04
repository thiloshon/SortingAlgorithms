using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Runner.Data.Project01
{
    class MergeSortBottomUp
    {
        void Sort<T>(T[] array, IComparer<T> comparer)
        {
            int n = array.Length;
            T[] src = array; // alias for the original
            T[] dest = (T[])new T[n]; // make a new temporary array
            T[] temp; // reference used only for swapping

            for (int i = 1; i < n; i *= 2) // each iteration sorts all runs of length i
            {
                for (int j = 0; j < n; j += 2 * i) // each pass merges two runs of length i
                    merge(src, dest, comparer, j, i);

                temp = src; // reverse roles of the arrays
                src = dest;
                dest = temp;
            }
            if (array != src)
                Array.Copy(src, 0, array, 0, n); // additional copy to get result to original
        }



        private void merge<T>(T[] inArray, T[] outArray, IComparer<T> comp, int start, int inc)
        {
            int end1 = Math.Min(start + inc, inArray.Length); // boundary for run 1
            int end2 = Math.Min(start + 2 * inc, inArray.Length);  // boundary for run 2
            int x = start; // index into run 1
            int y = start + inc; // index into run 2
            int z = start; // index into output

            while (x < end1 && y < end2)
                if (comp.compare(inArray[x], inArray[y]) < 0)
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

