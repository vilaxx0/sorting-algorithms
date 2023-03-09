using System;

namespace Sorting_Algorithms {
    abstract class SortingAlgorithm {
        public abstract void sortArray(ref int[] array);

        protected void swap(ref int a, ref int b) {
            int temp = a;
            a = b;
            b = temp;
        }
        
        public override string ToString() {
            return "Sorting Algorithm: ";
        }
    }
}