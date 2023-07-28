using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmSort
{
    public abstract class AlgoritmBase<T> where T : IComparable
    {
        public List<T> Items { get; set; } = new List<T>();

        public int countSwap { get; set; } = 0;

        public abstract void Sort();

        public void Swap(int x, int y)
        {
            var temp = Items[x];
            Items[x] = Items[y];
            Items[y] = temp;
            countSwap++;
        }
    }
}
