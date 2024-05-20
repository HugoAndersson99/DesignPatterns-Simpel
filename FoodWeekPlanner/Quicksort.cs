using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodWeekPlanner
{
    public class Quicksort
    {
        public void Sort(List<string> list)
        {
            Sort(list, 0, list.Count - 1);
        }

        private void Sort(List<string> list, int start, int end)
        {
            if (start < end)
            {
                int pivotIndex = Partition(list, start, end);
                Sort(list, start, pivotIndex - 1);
                Sort(list, pivotIndex + 1, end);
            }
        }
        private int Partition(List<string> list, int start, int end)
        {
            string pivot = list[end];
            int pivotIndex = start;
            for (int i = start; i < end; i++)
            {
                if (pivot.CompareTo(list[i]) == 1)
                {
                    Swap(list, i, pivotIndex);
                    pivotIndex++;
                }
            }
            Swap(list, end, pivotIndex);
            return pivotIndex;
        }
        private void Swap(List<string> list, int indexA, int indexB)
        {
            string temp = list[indexA];
            list[indexA] = list[indexB];
            list[indexB] = temp;
        }
    }
}

