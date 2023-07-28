using Microsoft.VisualStudio.TestTools.UnitTesting;
using AlgoritmSort;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmSort.Tests
{
    [TestClass()]
    public class SortTests
    {
        Random rnd = new Random();

        List<int> Items = new List<int>();
        List<int> Sorted = new List<int>();

        [TestInitialize]
        public void Init()
        {
            Items.Clear();
            for (int i = 0; i < 10000; i++)
            {
                Items.Add(rnd.Next(0, 1000));
            }
            Sorted.Clear();
            Sorted.AddRange(Items);
            Sorted.Sort();
        }

        [TestMethod()]
        public void InsertSortTest()
        {
            var insertSort = new InsertSort<int>();

            insertSort.Items.AddRange(Items);

            insertSort.Sort();

            for (int i = 0; i < Items.Count; i++)
            {
                Assert.AreEqual(Sorted[i], insertSort.Items[i]);
            }
        }

        [TestMethod()]
        public void CocktailSortTest()
        {
            var insertSort = new CocktailSort<int>();

            insertSort.Items.AddRange(Items);

            insertSort.Sort();

            for (int i = 0; i < Items.Count; i++)
            {
                Assert.AreEqual(Sorted[i], insertSort.Items[i]);
            }
        }

        [TestMethod()]
        public void ShellSortTest()
        {
            var insertSort = new ShellSort<int>();

            insertSort.Items.AddRange(Items);

            insertSort.Sort();

            for (int i = 0; i < Items.Count; i++)
            {
                Assert.AreEqual(Sorted[i], insertSort.Items[i]);
            }
        }

        [TestMethod()]
        public void DefaultSortTest()
        {
            Items.Sort();

            for (int i = 0; i < Items.Count; i++)
            {
                Assert.AreEqual(Sorted[i], Items[i]);
            }
        }

        [TestMethod()]
        public void SelectionSortTest()
        {
            var insertSort = new SelectionSort<int>();

            insertSort.Items.AddRange(Items);

            insertSort.Sort();

            for (int i = 0; i < Items.Count; i++)
            {
                Assert.AreEqual(Sorted[i], insertSort.Items[i]);
            }
        }
    }
}