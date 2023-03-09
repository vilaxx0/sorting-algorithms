using System;

namespace Sorting_Algorithms {
    class SelectionSort : SortingAlgorithm {
        /*
            Time Complexity
            Best case:      O(n^2)         
            Worst case:     O(n^2) 
            Average case:   O(n^2)
        */
        public override void SortArray(ref int[] array) {
            if(array.Length < 2) return;
            for(int i = 0; i < array.Length - 1; i++) {
                int iMin = i;
                
                for(int j = i + 1; j < array.Length; j++) {
                    if(array[j] < array[iMin])
                        iMin = j;
                }

                if(iMin != i) 
                    swap(ref array[i], ref array[iMin]);
            }
        }

        

        public override string ToString() {
            return base.ToString() + "Selection Sort";
        }
    }
}