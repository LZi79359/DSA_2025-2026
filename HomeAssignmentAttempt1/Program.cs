using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task 1.2.1
            /*
            int[] problemSizes = new int[] {1000, 10000, 100000, 1000000 };
            Random rng = new Random();
            
            
            Stopwatch sw = new Stopwatch();

            //Task 1.2.2
            MergeSort.Sort(new int[] { 5, 3, 1, 2, 4 });
            CountingSort.Sort(new int[] { 5, 3, 1, 2, 4 });

            for (int h = 0; h < 2; h++)
            {
                foreach (int problemSize in problemSizes)
                {
                    int[] testingArray = new int[problemSize];
                    for (int i = 0; i < testingArray.Length; i++)
                    {
                        testingArray[i] = rng.Next(1, 1000000);
                    }

                    if (h == 0)
                    {
                        sw.Start();
                        MergeSort.Sort(testingArray);
                        sw.Stop();
                        Console.WriteLine($"Merge Sort, Problem Size: {problemSize}: {sw.ElapsedMilliseconds}ms");
                    }
                    if (h == 1)
                    {
                        sw.Start();
                        CountingSort.Sort(testingArray);
                        sw.Stop();
                        Console.WriteLine($"Counting Sort, Problem Size: {problemSize}: {sw.ElapsedMilliseconds}ms");
                    }
                    sw.Restart();

                }
            }
            */

            //Task 1.3.2
            /*
            Random rng = new Random();

            bool mergeSortCorrect = true;
            bool countSortCorrect = true;

            for (int i = 0; i < 1000; i++)
            {
                int[] testingArray = new int[2000];

                for (int j = 0; j < 2000; j++)
                {
                   testingArray[j] = rng.Next(1, 1000000);
                }

                int[] arraySortedByMergeSort = MergeSort.Sort(testingArray);
                int[] arraySortedByCountSort = CountingSort.Sort(testingArray);
                Array.Sort(testingArray);

                for (int j = 0; j < 2000; j++)
                {
                    if (arraySortedByMergeSort[j] != testingArray[j])
                        mergeSortCorrect = false;

                    if (arraySortedByCountSort[j] != testingArray[j])
                        countSortCorrect = false;
                }
            }

            Console.WriteLine(
                mergeSortCorrect 
                ? "Merge Sort matches output provided by C# native Algorithm in all arrays" 
                : "Merge Sort does not match output provided by C#"
            );

            Console.WriteLine(
                countSortCorrect 
                ? "Count Sort matches output provided by C# native Algorithm in all arrays" 
                : "Count Sort does not match output provided by C#"
            );
            */
        }
    }
}
