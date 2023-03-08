using System;

namespace Sorting_Algorithms {
    abstract class SortingAlgorithm {
        public abstract void SortArray(ref int[] array);
        
        public override string ToString() {
            return "Sorting Algorithm: ";
        }
    }
}