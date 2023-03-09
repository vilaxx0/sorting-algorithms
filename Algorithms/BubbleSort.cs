using System;

namespace Sorting_Algorithms {
    class BubbleSort : SortingAlgorithm {
        /*
            Time Complexity
            Best case:      O(n)        
            Worst case:     O(n^2) 
            Average case:   O(n^2)
        */
        public override void sortArray(ref int[] array) {
            for(int i = 0; i < array.Length - 1; i++) {
                for(int j = 0; j < array.Length - i - 1; j++) {
                    if(array[j] > array[j+1]) {
                        swap(ref array[j], ref array[j+1]);
                    }
                }
            }
        }

        public override string ToString() {
            return base.ToString() + "Bubble Sort";
        }
    }
}