using System;

namespace Sorting_Algorithms {
    class BubbleSort : SortingAlgorithm {
        /*
            Time Complexity
            Best case:      O(n)        
            Worst case:     O(n^2) 
            Average case:   O(n^2)
        */
        public override void SortArray(ref int[] array) {
            if(array.Length < 2) return;

            // Way 1
            // for(int i = 0; i < array.Length - 1; i++) {
            //     for(int j = 0; j < array.Length - i - 1; j++) {
            //         if(array[j] > array[j+1]) {
            //             swap(ref array[j], ref array[j+1]);
            //         }
            //     }
            // }

            // Way 2
            bool swappedSomething = true;
            while(swappedSomething) {
                swappedSomething = false;
                for(int i = 0; i < array.Length - 1; i++) {
                    if(array[i] > array[i + 1]) {
                        swappedSomething = true;
                        swap(ref array[i], ref array[i + 1]);
                    }
                }
            }
        }

        public override string ToString() {
            return base.ToString() + "Bubble Sort";
        }
    }
}