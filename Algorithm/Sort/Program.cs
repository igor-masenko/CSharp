using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        static void Main(string[] args)
        {
            List<int> array = new List<int> { 1, 5, 2, 6, 8, 1, 10 };
            InsertionSortAsc(array);
            PrintArray(array, "Insertion sort asc: \t");

            InsertionSortDesc(array);
            PrintArray(array, "Insertion sort desc: \t");

            MergeSortAsc(array, 0, array.Count - 1);
            PrintArray(array, "Merge sort asc: \t");

            MergeSortDesc(array, 0, array.Count - 1);
            PrintArray(array, "Merge sort desc: \t");

            Console.ReadKey();
            
        }

    }
}
