using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmSort
{
    public class QuickSort<T> : AlgoritmBase<T> where T : IComparable
    {
        /* Описание Алгоритма
         * Быстрая сортировка (сортировка Хоара)
         * Одна из лучших сортировок (см. тесты)
         
         * Очень важен выбор pivot'a (опорного элемента)
         * pivot можно задачать: start | mid | end | random
         * гарантировать линейно-логарифмическую сложность

         * В данной реализаций будет выборт mid, для простоты понимания
       
         * O(n*logn) - в большестве случаев

         * Минусы:
         * O(n^2) - худший случай, при "частично отсортированом" массиве
        */

        public override void Sort()
        {
            Qsort(0, Items.Count - 1);
        }

        private void Qsort(int left, int right)
        {
            if (right <= left)
            {
                return;
            }

            var pivot = Sorting(left, right);
            Qsort(left, pivot - 1);
            Qsort(pivot + 1, right);
        }

        private int Sorting(int left, int right)
        {
            var pointer = left;

            for (int i = left; i <= right; i++)
            {
                if (Items[i].CompareTo(Items[right]) < 0)
                {
                    Swap(pointer, i);
                    pointer++;
                }
            }

            Swap(pointer, right);
            return pointer;
        }
    }
}
