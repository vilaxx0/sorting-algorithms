using System;
using System.Diagnostics;

namespace Sorting_Algorithms {
    class Program {
        static void Main(string[] args) {
            // Utils
            Utils helperUtils = new Utils();

            // Global variables
            SortingAlgorithm algorithm;
            int[] array;

            Console.WriteLine("Hello, welcome to Sorting Algorithms!");

            // User input
            algorithm = helperUtils.getAlgorithmType();
            array = helperUtils.getArrayForSorting();

            Console.WriteLine("1000 copies of the array will be made and each of them will be sorted.");
            Console.WriteLine("Sorting...");

            // Measure elapsed time of calculation
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            for(int i = 0; i < 999; i++) {
                int[] copyArray = (int[])array.Clone();
                algorithm.sortArray(ref copyArray);
            }
            algorithm.sortArray(ref array);

            stopwatch.Stop();

            long elapsedTimeMs = stopwatch.ElapsedMilliseconds;
            
            Console.WriteLine(string.Join(", ", array));
            Console.WriteLine($"Elapsed time: {elapsedTimeMs} ms");

            Console.ReadLine();
        }
    }
}