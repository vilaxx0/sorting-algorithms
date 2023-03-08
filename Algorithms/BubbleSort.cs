using System;

namespace Sorting_Algorithms {
    // O(n^2)
    class BubbleSort : SortingAlgorithm {
        public override void sortArray(ref int[] array) {
            for(int i = 0; i < array.Length - 1; i++) {
                for(int j = 0; j < array.Length - i - 1; j++) {
                    if(array[j] > array[j+1]) {
                        swap(ref array[j], ref array[j+1]);
                    }
                }
            }
        }

        private void swap(ref int a, ref int b) {
            int temp = a;
            a = b;
            b = temp;
        }

        public override string ToString() {
            return base.ToString() + "Bubble Sort";
        }
    }
}