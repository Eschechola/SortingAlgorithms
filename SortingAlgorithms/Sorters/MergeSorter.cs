using System;

namespace SortingAlgorithms.Sorters
{
    public static class MergeSorter
    {
        public static int[] OrderUsingMergeSort(this int[] array)
        {
            Sort(array: array, left: 0, right: array.Length - 1);
            return array;
        }

        private static void Sort(int[] array, int left, int right)
        {
            if(left < right)
            {
                int middle = (left + right) / 2;

                Sort(array: array, left: left, right: middle);
                Sort(array: array, left: middle + 1, right: right);

                Merge(array: array, left: left, middle: middle, right: right);
            }
        }

        private static void Merge(int[] array, int left, int middle, int right)
        {
            int leftArrayLenght = middle - left + 1;
            int rightArrayLenght = right - middle;

            int[] leftArray = new int[leftArrayLenght];
            int[] rightArray = new int[rightArrayLenght];

            DivideArray(sourceArray: array,
                targetArray: leftArray,
                startSource: left,
                startTarget: 0,
                lenght: leftArrayLenght);

            DivideArray(sourceArray: array,
                targetArray: rightArray, 
                startSource: middle + 1,
                startTarget: 0,
                lenght: rightArrayLenght);

            int leftCounter = 0;
            int rightCounter = 0;
            for (int i = left; i < right + 1; i++)
            {
                if (leftCounter == leftArray.Length)
                {
                    array[i] = rightArray[rightCounter];
                    rightCounter++;
                }
                else if (rightCounter == rightArray.Length)
                {
                    array[i] = leftArray[leftCounter];
                    leftCounter++;
                }
                else if (leftArray[leftCounter] <= rightArray[rightCounter])
                {
                    array[i] = leftArray[leftCounter];
                    leftCounter++;
                }
                else
                {
                    array[i] = rightArray[rightCounter];
                    rightCounter++;
                }
            }
        }

        private static void DivideArray(int[] sourceArray, int[] targetArray, int startSource, int startTarget, int lenght)
        {
            for (int i = startTarget; i < lenght; i++)
            {
                targetArray[i] = sourceArray[startSource];
                startSource++;
            }
        }
    }
}
