using System;
using System.Collections.Generic;

namespace Sort
{
    class Program
    {

        static private void PrintArray(List<int> array, string text = "")
        {
            Console.Write(text);
            foreach (var element in array)
                Console.Write($"{element} ");
            Console.WriteLine();
        }

        #region InsertionSort
        static private void InsertionSortAsc(List<int> array)
        {
            for (var sortedIndex = 1; sortedIndex < array.Count; sortedIndex++)
            {
                var loopInvariant = sortedIndex - 1;

                while (loopInvariant > -1 && array[loopInvariant] > array[loopInvariant + 1])
                {
                    (array[loopInvariant], array[loopInvariant + 1]) = (array[loopInvariant + 1], array[loopInvariant]);
                    loopInvariant--;
                }
            }
        }

        static private void InsertionSortDesc(List<int> array)
        {
            for (var sortedIndex = 1; sortedIndex < array.Count; sortedIndex++)
            {
                var loopInvariant = sortedIndex - 1;

                while (loopInvariant > -1 && array[loopInvariant] < array[loopInvariant + 1])
                {
                    (array[loopInvariant], array[loopInvariant + 1]) = (array[loopInvariant + 1], array[loopInvariant]);
                    loopInvariant--;
                }
            }
        }

        #endregion

        #region MergeSort
        static private void MergeAsc(List<int> array, int beginingIndex, int separatorIndex, int endingIndex)
        {
            if (beginingIndex <= endingIndex 
                && ((beginingIndex <= separatorIndex) || (separatorIndex <= endingIndex)))
            {
                var leftArrayLength = separatorIndex - beginingIndex + 1;
                var rightArrayLength = endingIndex - separatorIndex;

                var leftArray = new List<int>(array.GetRange(beginingIndex, leftArrayLength));
                var rightArray = new List<int>(array.GetRange(separatorIndex + 1, rightArrayLength));

                var leftArrayIndex = 0;
                var rightArrayIndex = 0;

                for (int arrayIndex = beginingIndex; arrayIndex <= endingIndex; arrayIndex++)
                {
                    if (rightArrayIndex < rightArrayLength && leftArrayIndex < leftArrayLength)
                    {
                        if (leftArray[leftArrayIndex] <= rightArray[rightArrayIndex])
                        {
                            array[arrayIndex] = leftArray[leftArrayIndex];
                            leftArrayIndex++;
                        }
                        else
                        {
                            array[arrayIndex] = rightArray[rightArrayIndex];
                            rightArrayIndex++;
                        }
                    }
                    else if (leftArrayLength >= leftArrayIndex && rightArrayIndex < rightArrayLength)
                    {
                        array[arrayIndex] = rightArray[rightArrayIndex];
                        rightArrayIndex++;
                    }
                    else if (rightArrayLength >= rightArrayIndex && leftArrayIndex < leftArrayLength)
                    {
                        array[arrayIndex] = leftArray[leftArrayIndex];
                        leftArrayIndex++;
                    }
                }
            }
        }

        static private void MergeDesc(List<int> array, int beginingIndex, int separatorIndex, int endingIndex)
        {
            if (beginingIndex <= endingIndex
                && ((beginingIndex <= separatorIndex) || (separatorIndex <= endingIndex)))
            {
                var leftArrayLength = separatorIndex - beginingIndex + 1;
                var rightArrayLength = endingIndex - separatorIndex;

                var leftArray = new List<int>(array.GetRange(beginingIndex, leftArrayLength));
                var rightArray = new List<int>(array.GetRange(separatorIndex + 1, rightArrayLength));

                var leftArrayIndex = 0;
                var rightArrayIndex = 0;

                for (int arrayIndex = beginingIndex; arrayIndex <= endingIndex; arrayIndex++)
                {
                    if (rightArrayIndex < rightArrayLength && leftArrayIndex < leftArrayLength)
                    {
                        if (leftArray[leftArrayIndex] > rightArray[rightArrayIndex])
                        {
                            array[arrayIndex] = leftArray[leftArrayIndex];
                            leftArrayIndex++;
                        }
                        else
                        {
                            array[arrayIndex] = rightArray[rightArrayIndex];
                            rightArrayIndex++;
                        }
                    }
                    else if (leftArrayLength >= leftArrayIndex && rightArrayIndex < rightArrayLength)
                    {
                        array[arrayIndex] = rightArray[rightArrayIndex];
                        rightArrayIndex++;
                    }
                    else if (rightArrayLength >= rightArrayIndex && leftArrayIndex < leftArrayLength)
                    {
                        array[arrayIndex] = leftArray[leftArrayIndex];
                        leftArrayIndex++;
                    }
                }
            }
        }

        static private void MergeSortAsc(List<int> array, int beginingIndex, int endingIndex)
        {
            if (beginingIndex < endingIndex)
            {
                var separatorIndex = (int)Math.Floor((decimal)(beginingIndex + endingIndex) / 2);
                MergeSortAsc(array, beginingIndex, separatorIndex);
                MergeSortAsc(array , separatorIndex + 1, endingIndex);
                MergeAsc(array, beginingIndex, separatorIndex, endingIndex);
            }
        }

        static private void MergeSortDesc(List<int> array, int beginingIndex, int endingIndex)
        {
            if (beginingIndex < endingIndex)
            {
                var separatorIndex = (int)Math.Floor((decimal)(beginingIndex + endingIndex) / 2);
                MergeSortDesc(array, beginingIndex, separatorIndex);
                MergeSortDesc(array, separatorIndex + 1, endingIndex);
                MergeDesc(array, beginingIndex, separatorIndex, endingIndex);
            }
        }

        #endregion

        #region SelectionSort
        static private void SelectionSortAsc(List<int> array)
        {
            if (array.Count > 0)
            {
                for(var index = 0; index < array.Count - 1; index++)
                {
                    var min = Int32.MaxValue;
                    var swampIndex = index;
                    for (var minIndex = index; minIndex < array.Count; minIndex++)
                        if (min >= array[minIndex])
                        {
                            min = array[minIndex];
                            swampIndex = minIndex;
                        }

                    (array[index], array[swampIndex]) = (min, array[index]);
                }
            }
        }

        static private void SelectionSortDesc(List<int> array)
        {
            if (array.Count > 0)
            {
                for (var index = 0; index < array.Count - 1; index++)
                {
                    var max = Int32.MinValue;
                    var swampIndex = index;
                    for (var maxIndex = index; maxIndex < array.Count; maxIndex++)
                        if (max <= array[maxIndex])
                        {
                            max = array[maxIndex];
                            swampIndex = maxIndex;
                        }

                    (array[index], array[swampIndex]) = (max, array[index]);
                }
            }
        }

        #endregion

        static void Main(string[] args)
        {
            List<int> array = new List<int> { 2, 5, 1, 6, 8, 1, 10 };
            List<int> sortedArray = array;
            
            InsertionSortAsc(sortedArray);
            PrintArray(sortedArray, "Insertion sort asc: \t");

            sortedArray = array;
            InsertionSortDesc(sortedArray);
            PrintArray(sortedArray, "Insertion sort desc: \t");

            sortedArray = array;
            MergeSortAsc(sortedArray, 0, sortedArray.Count - 1);
            PrintArray(sortedArray, "Merge sort asc: \t");

            sortedArray = array;
            MergeSortDesc(sortedArray, 0, sortedArray.Count - 1);
            PrintArray(sortedArray, "Merge sort desc: \t");

            sortedArray = array;
            SelectionSortAsc(sortedArray);
            PrintArray(sortedArray, "Select sort asc: \t");
            
            sortedArray = array;
            SelectionSortDesc(sortedArray);
            PrintArray(sortedArray, "Select sort desc: \t");

            Console.ReadKey();
            
        }

    }
}
