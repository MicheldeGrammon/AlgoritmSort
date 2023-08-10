using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmSort
{
    public class CocktailSort<T> : AlgoritmBase<T> where T : IComparable
    {

        /* Описание Алгоритма
         * Шейкерная сортировка (двухстороняя пузырьковая сортировка)
         * почти не применяется на практике

         * O(n) - лучший вариант
         * O(n^2) - худший
        */

        public override void Sort()
        {
            int left = 0;
            int right = Items.Count - 1;

            countSwap = 0;

            while (left < right)
            {
                var oldSwap = countSwap;
                for (int i = left; i < right; i++)
                {
                    if (Items[i].CompareTo(Items[i + 1]) == 1)
                    {
                        Swap(i, i + 1);
                    }
                }
                right--;

                if (oldSwap == countSwap)
                {
                    break;
                }

                for (int i = right; i > left; i--)
                {
                    if (Items[i].CompareTo(Items[i - 1]) == -1)
                    {
                        Swap(i, i - 1);
                    }
                }
                left++;

                if (oldSwap == countSwap)
                {
                    break;
                }
            }
        }
    }
}
