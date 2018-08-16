using DataStructures_Algorithms.Week03;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures_Algorithms.Project01
{
    public class MergeSortTopDown : ISorter
    {
        private Random random = new Random();

        public void Sort<T>(T[] array, IComparer<T> comparer) where T : IComparable<T>
        {
            if (comparer == null) comparer = Comparer<T>.Default;

            int n = array.Length;
            if (n < 2) return;

            int mid = n / 2;

            T[] s1 = array.Take(n / 2).ToArray();
            T[] s2 = array.Skip(n / 2).ToArray();

            Sort(s1, comparer);
            Sort(s2, comparer);

            Merge(s1, s2, array, comparer);
        }

        private void Merge<T>(T[] leftArray, T[] rightArray, T[] array, IComparer<T> comparer)
        {
            int i = 0; 
             int   j = 0;

            while (i + j < array.Length)
            {
                if (j == rightArray.Length || (i < leftArray.Length && comparer.Compare(leftArray[i], rightArray[j]) < 0))
                    array[i + j] = leftArray[i++];
                else
                    array[i + j] = rightArray[j++];
            }
        }
    }
}
