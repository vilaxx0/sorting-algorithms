using System;

namespace Sorting_Algorithms {
    abstract class SortingAlgorithm {
        public abstract int[] SortArray();
        
        public override string ToString() {
            return "Sorting Algorithm: ";
        }
    }
}