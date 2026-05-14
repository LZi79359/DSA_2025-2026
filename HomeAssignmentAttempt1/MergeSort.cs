using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeAssignmentAttempt1
{
    /// <summary>
    /// Merge Sort Algorithm
    /// Best Case: O(n log n)
    /// Avg Case: O(n log n)
    /// Worst Case: O(n log n)
    /// </summary>
    public class MergeSort
    {
        public static int[] Sort(int[] unsortedArray)
        {
            int[] arrayCopy = (int[])unsortedArray.Clone();
            MergeSortHelper(arrayCopy, 0, arrayCopy.Length - 1);
            return arrayCopy;
        }

        private static void MergeSortHelper(int[] ints, int left, int right )
        {
            if (left >= right) return;
            int midPoint = (left + right) / 2;
            MergeSortHelper(ints, left, midPoint);
            MergeSortHelper(ints, midPoint+1, right);
            
            int[] tempArray = new int[right-left+1];
            int leftPointer = left;
            int rightPointer = midPoint + 1;
            int rank = 0;

            while(leftPointer <= midPoint && rightPointer <= right)
            {
                if (ints[leftPointer] < ints[rightPointer])
                {
                    tempArray[rank] = ints[leftPointer];
                    leftPointer++;
                }
                else
                {
                    tempArray[rank] = ints[rightPointer];
                    rightPointer++;
                }
                rank++;
            }

            while (leftPointer <= midPoint)
            {
                tempArray[rank] = ints[leftPointer];
                leftPointer++;
                rank++;
            }

            while (rightPointer <= right)
            {
                tempArray[rank] = ints[rightPointer];
                rightPointer++;
                rank++;
            }

            for (int i = 0; i < tempArray.Length; i ++)
            {
                ints[left+i] = tempArray[i];
            }
        }
    }
}
