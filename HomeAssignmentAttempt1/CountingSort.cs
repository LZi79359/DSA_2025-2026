using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeAssignmentAttempt1
{
    /// <summary>
    /// Counting Sort
    /// Best Case = O(n+k)
    /// Average Case = O(n+k)
    /// Worst Case = O(n+k)
    /// </summary>
    public class CountingSort
    {
        public static int[] Sort(int[] unsortedArray)
        {
            int[] arrayCopy = (int[])unsortedArray.Clone();
            CountSortHelper(arrayCopy);
            return arrayCopy;
        }

        private static void CountSortHelper(int[] ints)
        {
            int max = ints[0];

            foreach (int i in ints)
            {
                if (max < i) max = i;
            }

            int[] count = new int[max + 1];

            foreach (int i in ints)
            {
                count[i]++;
            }

            int rank = 0;
            for (int i = 0; i <= max; i++)
            {
                for (int j = 0; j < count[i]; j++)
                {
                    ints[rank] = i;
                    rank++;
                }
            }
        }

    }
}
