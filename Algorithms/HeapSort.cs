using System;

namespace Sorting_Algorithms {
    class HeapSort : SortingAlgorithm {
        /*
            Time Complexity
            Best case:      O(n log n)         
            Worst case:     O(n log n) 
            Average case:   O(n log n)
        */
        public override void SortArray(ref int[] array) {
            if(array.Length < 2) return;
            
            int heapSize = array.Length;

            // Build heap/Rearrange array
            for(int i = (heapSize / 2) - 1; i >= 0; i--) {
                heapify(ref array, heapSize, i);
            }

            // Extract elements one-by-one
            for(int i = heapSize - 1; i > 0; i--) {
                swap(ref array[0], ref array[i]);
                heapify(ref array, i, 0);
            }
        }

        private void heapify(ref int[] array, int heapSize, int parentIndex) {
            /*  
                Max-Heap ✅
                    (21)        -- parent
                   /    \
                (17)    (15)    -- children

                Needs fix ❌
                    (9)
                   /   \
                (13)  (18)
            */

            int newLargestIndex = parentIndex;

            int childLeftIndex = (2 * parentIndex) + 1;
            int childRightIndex = (2 * parentIndex) + 2;

            if(childLeftIndex < heapSize && array[childLeftIndex] > array[newLargestIndex]) {
                newLargestIndex = childLeftIndex;
            }

            if(childRightIndex < heapSize && array[childRightIndex] > array[newLargestIndex]) {
                newLargestIndex = childRightIndex;
            }

            if(newLargestIndex != parentIndex) {
                swap(ref array[parentIndex], ref array[newLargestIndex]);
                heapify(ref array, heapSize, newLargestIndex);
            }

        }

        public override string ToString() {
            return base.ToString() + "Heap Sort";
        }
    }
}