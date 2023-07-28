using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmSort
{
    public class ShellSort<T> : AlgoritmBase<T> where T : IComparable
    {
        /* Описание Алгоритма
         * Сортировка Шелла
         * но в целом не лучший вариант

         * O(n) - лучший вариаент
         * O(n*logn) - средний случай
         * O(n^2) - худший
        */
        public override void Sort()
        {
            countSwap = 0;

            var step = Items.Count / 2;

            while (step > 0)
            {
                for (int i = step; i < Items.Count; i++)
                {
                    int index = i;
                    while ((index >= step) && Items[index - step].CompareTo(Items[index]) == 1)
                    {
                        Swap(index - step, index);
                        index -= step;
                    }
                }

                step = step / 2;
            }
        }
    }
}
