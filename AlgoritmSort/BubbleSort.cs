using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmSort
{
    public class BubbleSort<T> : AlgoritmBase<T> where T : IComparable
    {

        /* Описание Алгоритма
         * Пузырьковая сортировка
         * не применяется на практике

         * O(n) - лучший вариант
         * O(n^2) - худший
        */

        public override void Sort()
        {
            for (int i = 0; i < Items.Count; i++)
            {
                var oldCountSwap = countSwap;
                for (int j = 0; j < Items.Count - 1; j++)
                {
                    if (Items[j].CompareTo(Items[j + 1]) == 1)
                    {
                        Swap(j, j + 1);
                    }
                }

                if (countSwap == oldCountSwap)
                {
                    break;
                }
            }
        }
    }
}
