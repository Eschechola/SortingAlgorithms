namespace SortingAlgorithms.Sorters
{
    public static class Sorter
    {
        public static int[] OrderUsingQuickSort(this int[] array)
        {
            QuickSort(array: array, begin: 0, end: array.Length - 1);
            return array;
        }

        private static void QuickSort(int[] array, int begin, int end)
        {
            if (begin < end)
            {
                int pivotIndex = GetPivotIndex(array, begin, end);

                QuickSort(array: array, begin: begin, end: pivotIndex - 1);
                QuickSort(array: array, begin: pivotIndex + 1, end: end);
            }
        }

        private static int GetPivotIndex(int[] array, int begin, int end)
        {
            int pivot = array[end];
            int pivotIndex = begin - 1;

            for(int i = begin; i < end; i++)
            {
                if(array[i] <= pivot)
                {
                    pivotIndex++;
                    ChangePositions(array, pivotIndex, i);
                }
            }

            ChangePositions(array, pivotIndex + 1, end);
            return pivotIndex + 1;
        }

        private static void ChangePositions(int[] array, int currentElement, int newElement)
        {
            int temp = array[currentElement];
            array[currentElement] = array[newElement];
            array[newElement] = temp;
        }
    }
}
