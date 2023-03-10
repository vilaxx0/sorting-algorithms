using System;

namespace Sorting_Algorithms {
    class InsertionSort : SortingAlgorithm {
        /*
            Time Complexity
            Best case:      O(n)        
            Worst case:     O(n^2) 
            Average case:   O(n^2)
        */
        public override void SortArray(ref int[] array) {
            if(array.Length < 2) return;
            for(int i = 1; i < array.Length; i++) {
                bool sorted = true;
                for(int j = i; j > 0; j--) {
                    if(array[j-1] > array[j]) {
                        swap(ref array[j-1], ref array[j]);
                        sorted = false;
                    }

                    if(sorted)
                        break;
                }
            }
        }

        public override string ToString() {
            return base.ToString() + "Insertion Sort";
        }
    }
}