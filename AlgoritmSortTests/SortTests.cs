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
            var cocktailSort = new CocktailSort<int>();

            cocktailSort.Items.AddRange(Items);

            cocktailSort.Sort();

            for (int i = 0; i < Items.Count; i++)
            {
                Assert.AreEqual(Sorted[i], cocktailSort.Items[i]);
            }
        }

        [TestMethod()]
        public void ShellSortTest()
        {
            var shellSort = new ShellSort<int>();

            shellSort.Items.AddRange(Items);

            shellSort.Sort();

            for (int i = 0; i < Items.Count; i++)
            {
                Assert.AreEqual(Sorted[i], shellSort.Items[i]);
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
            var selectionSort = new SelectionSort<int>();

            selectionSort.Items.AddRange(Items);

            selectionSort.Sort();

            for (int i = 0; i < Items.Count; i++)
            {
                Assert.AreEqual(Sorted[i], selectionSort.Items[i]);
            }
        }

        [TestMethod()]
        public void BubbleSortTest()
        {
            var bubbleSort = new BubbleSort<int>();

            bubbleSort.Items.AddRange(Items);

            bubbleSort.Sort();

            for (int i = 0; i < Items.Count; i++)
            {
                Assert.AreEqual(Sorted[i], bubbleSort.Items[i]);
            }
        }

        [TestMethod()]
        public void RadixSortTest()
        {
            var radixSort = new RadixSort<int>();

            radixSort.Items.AddRange(Items);

            radixSort.Sort();

            for (int i = 0; i < Items.Count; i++)
            {
                Assert.AreEqual(Sorted[i], radixSort.Items[i]);
            }
        }

        [TestMethod()]
        public void MergeSortTest()
        {
            var mergeSort = new MergeSort<int>();

            mergeSort.Items.AddRange(Items);

            mergeSort.Sort();

            for (int i = 0; i < Items.Count; i++)
            {
                Assert.AreEqual(Sorted[i], mergeSort.Items[i]);
            }
        }
    }
}