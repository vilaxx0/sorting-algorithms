using System;

namespace Sorting_Algorithms {
    class HeapSort : SortingAlgorithm {
        public override void SortArray(ref int[] array) {
            if(array.Length < 2) return;
            throw new NotImplementedException();
        }

        public override string ToString() {
            return base.ToString() + "Heap Sort";
        }
    }
}