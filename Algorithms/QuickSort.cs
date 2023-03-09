using System;

namespace Sorting_Algorithms {
    
    class QuickSort : SortingAlgorithm {
        /*
            Time Complexity
            Best case:      O(n log n)         
            Worst case:     O(n^2) 
            Average case:   O(n log n)
        */
        public override void sortArray(ref int[] array) {
            quickSort(ref array, 0, array.Length - 1);
        }

        private void quickSort(ref int[] array, int lowestIndex, int highestIndex) {
            if(lowestIndex < highestIndex) {
                int pivotIndex = partition(ref array, lowestIndex, highestIndex);
                quickSort(ref array, lowestIndex, pivotIndex - 1);
                quickSort(ref array, pivotIndex + 1, highestIndex);
            }
        }

        private int partition(ref int[] array, int lowestIndex, int highestIndex) {
            int pivotValue = array[highestIndex];

            int minIndex = lowestIndex - 1;
            
            for(int i = lowestIndex; i < highestIndex; i++) {
                if(array[i] < pivotValue) {
                    minIndex++;
                    swap(ref array[minIndex], ref array[i]);
                } 
            }

            swap(ref array[minIndex+1], ref array[highestIndex]);
            return minIndex + 1;
        }

        public override string ToString() {
            return base.ToString() + "Quick Sort";
        }
    }
}