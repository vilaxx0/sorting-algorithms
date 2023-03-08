using System;

namespace Sorting_Algorithms {
    class SelectionSort : SortingAlgorithm {
        // O(n^2)
        public override void sortArray(ref int[] array) {
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

        private void swap(ref int a, ref int b) {
            int temp = a;
            a = b;
            b = temp;
        }

        public override string ToString() {
            return base.ToString() + "Selection Sort";
        }
    }
}