using System;

namespace Sorting_Algorithms {
    class MergeSort : SortingAlgorithm {
        /*
            Time Complexity
            Best case:      O(n log n)     
            Worst case:     O(n log n) 
            Average case:   O(n log n) 
        */
        public override void SortArray(ref int[] array) {
            if(array.Length < 2) return;

            int len = array.Length;
            int midIndex = len / 2; 
            int[] leftHalf = new int[midIndex];
            int[] rightHalf = new int[len - midIndex];

            for(int i = 0; i < midIndex; i++) {
                leftHalf[i] = array[i];
            }

            for(int i = midIndex; i < len; i++) {
                rightHalf[i - midIndex] = array[i];
            }

            SortArray(ref leftHalf);
            SortArray(ref rightHalf);

            merge(ref array, ref leftHalf, ref rightHalf);
        }

        private void merge(ref int[] array,ref int[] leftHalf, ref int[] rightHalf) {
            int lenLeft = leftHalf.Length;
            int lenRight = rightHalf.Length;

            int i = 0, j = 0, k = 0;

            while(i < lenLeft && j < lenRight) {
                if(leftHalf[i] <= rightHalf[j]) {
                    array[k] = leftHalf[i];
                    i++;
                } else {
                    array[k] = rightHalf[j];
                    j++;
                }
                k++;
            }

            while (i < lenLeft) {
                array[k] = leftHalf[i];
                i++;
                k++;
            }
            while (j < lenRight) {
                array[k] = rightHalf[j];
                j++;
                k++;
            }
            
        }

        public override string ToString() {
            return base.ToString() + "Merge Sort";
        }
    }
}