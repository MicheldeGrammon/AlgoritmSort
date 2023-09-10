using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmSort
{
    public class SelectionSort<T> : AlgoritmBase<T> where T : IComparable
    {
        /* Описание Алгоритма
         * Сортировка вставками
         * хорошо работает в частично отсортрованных колекциях (см. алгоритм Шелла)
         * но в целом не лучший вариант

         * O(n^2) - всегда
        */

        public override void Sort()
        {
            for (int i = 0; i < Items.Count - 1; i++)
            {
                int index = i;
                for (int j = index + 1; j < Items.Count; j++)
                {
                    if (Items[j].CompareTo(Items[index]) == -1)
                    {
                        index = j;
                    }
                }
                Swap(index, i);
            }
        }
    }
}
