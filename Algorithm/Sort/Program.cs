using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort
{
    class Program
    {
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
        static void Main(string[] args)
        {
            List<int> array = new List<int> { 1, 5, 2, 6, 8, 1};
            InsertionSortAsc(array);

            foreach(var element in array)
            {
                Console.Write("{0} ", element);
            }
            Console.WriteLine();

            InsertionSortDesc(array);

            foreach (var element in array)
            {
                Console.Write("{0} ", element);
            }
            Console.WriteLine();
        }

    }
}
