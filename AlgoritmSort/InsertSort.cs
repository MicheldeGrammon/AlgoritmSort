using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmSort
{
    public class InsertSort<T> : AlgoritmBase<T> where T : IComparable
    {
        /* Описание Алгоритма
         * Сортировка вставками
         * хорошо работает в частично отсортрованных колекциях (см. алгоритм Шелла)
         * но в целом не лучший вариант

         * O(n) - лучший вариант
         * O(n*logn) - средний случай (не верю)
         * O(n^2) - худший
        */
        public override void Sort()
        {
            for (int i = 1; i < Items.Count; i++)
            {
                var temp = Items[i];

                var index = i;

                while (index > 0 && temp.CompareTo(Items[index - 1]) == -1)
                {
                    Swap(index, index-1);
                    index--;
                }
            }
        }
    }
}
