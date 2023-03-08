using System;

namespace Sorting_Algorithms {
    class Program {
        static void Main(string[] args) {
            Utils helperUtils = new Utils();

            SortingAlgorithm algorithm;
            int[] list;

            Console.WriteLine("Hello, welcome to Sorting Algorithms!");

            algorithm = helperUtils.getAlgorithmType();
            list = helperUtils.getListForSorting();

            Console.ReadLine();
        }
    }
}