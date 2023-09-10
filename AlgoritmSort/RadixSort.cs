using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AlgoritmSort
{
    public class RadixSort<T> : AlgoritmBase<T> where T : IComparable
    {
        /* Описание Алгоритма
         * Порязрядная сотртировка (для понимая вспомни сортировку подсчетом)
         * Одна из самых быстрых сортировок
         * Требуется наперед знать "алфавит" и выделить для него место

         * O(n * k/d)
         * k - max_length - максимальная длина элемента (разрадяность)
         * d - алфавит (необходимо знать алфавит или составить его)
         * Помни что есть LSD(числовой порядок, для чисел) и MSD (алфавитный порядок, для текста)
        */

        public override void Sort()
        {
            int chek = 0;
            if (typeof(T) != chek.GetType())
            {
                throw new Exception("only int");
            }

            // Так как мы сортируем числа то создадим алфавит(корзины) из цифр
            // алфавит можно было не указывать, так как он простой

            var group = new Dictionary<int, Queue<T>>()
            {
                { 0, new Queue<T>() },
                { 1, new Queue<T>() },
                { 2, new Queue<T>() },
                { 3, new Queue<T>() },
                { 4, new Queue<T>() },
                { 5, new Queue<T>() },
                { 6, new Queue<T>() },
                { 7, new Queue<T>() },
                { 8, new Queue<T>() },
                { 9, new Queue<T>() },
            };
            // ВНИМАНИЕ!!! в данном случай алгоритмы будет работать только на положительных целых числах

            var countItems = Items.Count;
            var maxLength = GetMaxLength();

            for (int i = 0; i < maxLength; i++)
            {
                //сборка корзин
                for (int j = 0; j < countItems; j++)
                {
                    var hashCode = Items[j].GetHashCode();
                    var temp = hashCode % (int)Math.Pow(10, i + 1) / (int)Math.Pow(10, i);
                    group[temp].Enqueue(Items[j]);
                }

                Items.Clear();

                //разборка корзин, так как у нас используется очередь сразу происходит очистка корзин.
                for (int j = 0; j < group.Count; j++)
                {
                    while (group[j].Count > 0)
                    {
                        Items.Add(group[j].Dequeue());
                    }
                }
            }
        }

        //метод получения максимальной разрядности (длины слова/числа)
        private int GetMaxLength()
        {
            var maxLength = 0;

            for (int i = 0; i < Items.Count; i++)
            {
                maxLength = Math.Max(maxLength, Items[i].ToString().Length);
            }

            return maxLength;
        }
    }
}
