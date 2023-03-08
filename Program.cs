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

            Console.WriteLine("Sorting...");

            // Measure elapsed time of calculation
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            // algorithm.SortArray(ref array);
            
            stopwatch.Stop();
            long elapsedTimeMs = stopwatch.ElapsedMilliseconds;
            Console.WriteLine($"Elapsed time: {elapsedTimeMs} ms");

            Console.ReadLine();
        }
    }
}