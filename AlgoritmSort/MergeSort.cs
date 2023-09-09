using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmSort
{
    public class MergeSort<T> : AlgoritmBase<T> where T : IComparable
    {
        /* Описание Алгоритма
         * Сортировка слиянием
         * Одна из лучших сортировок (см. тесты)
         * "Разделяй и властвуй"        
         * Хорош, при потоке (последовательном получении данных)
         
         * Существует два подхода (снизу вверх, сверху вниз),
         * а так же различные виды: (каскадная, многофазная и т.д.)
         
         * Минусы:
         * требует доп. пространство ("буфер")
         * на "частично отсортрованых" массивах работает не так эффективно

         * O(n*logn) - всегда
        */

        public override void Sort()
        {
            Items = Sort(Items);
        }

        private List<T> Sort(List<T> items)
        {
            if (items.Count == 1 || items.Count == 0)
            {
                return items;
            }

            var mid = items.Count / 2;

            var left = items.Take(mid).ToList(); //для удобаства и понимая не IEnumerable
            var right = items.Skip(mid).ToList();

            return Merge(Sort(left), Sort(right));
        }

        private List<T> Merge(List<T> left, List<T> right)
        {
            var result = new List<T>();

            var length = left.Count + right.Count;
            var leftIndex = 0;
            var rightIndex = 0;

            while (length > 0) 
            { 
                if (leftIndex < left.Count && rightIndex < right.Count) 
                { 
                    if (left[leftIndex].CompareTo(right[rightIndex]) == -1)
                    {
                        result.Add(left[leftIndex]);
                        leftIndex++;
                    }
                    else 
                    {
                        result.Add(right[rightIndex]);
                        rightIndex++;
                    }
                }
                else
                {
                    if (rightIndex == right.Count) 
                    {
                        result.Add(left[leftIndex]);
                        leftIndex++;
                    }
                    else
                    {
                        result.Add(right[rightIndex]);
                        rightIndex++;
                    }
                }
                length--;
            }

            return result;
        }
    }
}
