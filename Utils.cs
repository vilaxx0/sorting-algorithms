using System;
using System.Text.RegularExpressions;

namespace Sorting_Algorithms {
    class Utils {
        private int[] list = {10, 6, 2, 4, 3, 5, 1, 8, 9, 7};
        public SortingAlgorithm getAlgorithmType() {
            SortingAlgorithm? algorithm = null;

            Console.WriteLine("Please select a sorting algorithm you would like to use.");
            Console.WriteLine("1. Bubble Sort");
            Console.WriteLine("2. Selection Sort");
            Console.WriteLine("3. Insertion Sort");
            Console.WriteLine("4. Merge Sort");
            Console.WriteLine("5. Quick Sort");
            Console.WriteLine("6. Heap Sort");

            while(true) {
                if(!int.TryParse(Console.ReadLine(), out int answer)) {
                    // If it fails to parse
                    Console.WriteLine("Please type an integer number.");
                    continue;
                } 

                if(answer < 1 || answer > 6) {
                    Console.WriteLine("Please type a number from 1-6.");
                    continue;
                }

                switch (answer) {
                    case 1:
                        algorithm = new BubbleSort();
                        break;
                    case 2:
                        algorithm = new SelectionSort();
                        break;
                    case 3:
                        algorithm = new InsertionSort();
                        break;
                    case 4:
                        algorithm = new MergeSort();
                        break;
                    case 5:
                        algorithm = new QuickSort();
                        break;
                    case 6:
                        algorithm = new HeapSort();
                        break;
                }

                if(algorithm != null) {
                    break;
                }
            }

            if (algorithm == null) {
                throw new Exception("An error occurred: Unable to select a sorting algorithm");
            }

            Console.WriteLine($"You choose {algorithm.ToString()}");
            return algorithm;
        }

        public int[] getArrayForSorting() {
            Console.WriteLine("Would you like to provide a custom list or use a pre-configured one?");
            Console.WriteLine("1. Custom List");
            Console.WriteLine("2. Pre-configured List");

            while(true) {
                if(!int.TryParse(Console.ReadLine(), out int answer)) {
                    // If it fails to parse
                    Console.WriteLine("Please type an integer number.");
                    continue;
                }   

                if(answer < 1 || answer > 2) {
                    Console.WriteLine("Only acceptable values are 1 and 2");
                    continue;
                }

                if(answer == 1) {
                    Console.WriteLine("Please provide a list of integer numbers separated by spaces. (last character cannot be space)");
                    
                    if(getCustomList(out int[] customList)) {
                        Console.WriteLine($"You choose a custom list: {string.Join(", ",customList)}");
                        return customList;
                    } else {
                        Console.WriteLine($"An error occurred selecting custom list. Pre-defined list will be used: {string.Join(", ", list)}");
                        return list;
                    }
                }

                Console.WriteLine($"You choose a pre-configured list: {string.Join(", ", list)}");
                return list;
                
            }
        }

        private bool getCustomList(out int[] customList) {
            while(true) {
                string? input = Console.ReadLine();

                if (input == null) {
                    Console.WriteLine("Received null. Try again...");
                    continue;
                } 

                // Regex: check if the received string contains only numbers separated by spaces
                bool isValid = Regex.IsMatch(input, @"^\d+(\s\d+)*$");

                if(!isValid) {
                    Console.WriteLine("The input only accepts integer numbers and the last character cannot be space. Try again...");
                    continue;
                }

                customList = input.Split(" ").Select(x => int.Parse(x)).ToArray();
                return true;
            }
        }
    }
}