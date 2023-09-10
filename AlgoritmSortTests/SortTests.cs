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

        List<int> RandomItems = new List<int>();
        List<int> Sorted = new List<int>();

        [TestInitialize]
        public void Init()
        {
            RandomItems.Clear();
            for (int i = 0; i < 100000; i++)
            {
                RandomItems.Add(rnd.Next(0, 1000));
            }

            Sorted.Clear();
            Sorted.AddRange(RandomItems.OrderBy(x => x).ToArray());
        }


        [TestMethod()]
        public void InsertSortTest()
        {
            var insertSort = new InsertSort<int>();

            insertSort.Items.AddRange(RandomItems);

            insertSort.Sort();

            for (int i = 0; i < RandomItems.Count; i++)
            {
                Assert.AreEqual(Sorted[i], insertSort.Items[i]);
            }
        }

        [TestMethod()]
        public void CocktailSortTest()
        {
            var cocktailSort = new CocktailSort<int>();

            cocktailSort.Items.AddRange(RandomItems);

            cocktailSort.Sort();

            for (int i = 0; i < RandomItems.Count; i++)
            {
                Assert.AreEqual(Sorted[i], cocktailSort.Items[i]);
            }
        }

        [TestMethod()]
        public void ShellSortTest()
        {
            var shellSort = new ShellSort<int>();

            shellSort.Items.AddRange(RandomItems);

            shellSort.Sort();

            for (int i = 0; i < RandomItems.Count; i++)
            {
                Assert.AreEqual(Sorted[i], shellSort.Items[i]);
            }
        }

        [TestMethod()]
        public void DefaultSortTest()
        {
            var defautSort = new List<int>();

            defautSort.AddRange(RandomItems);

            defautSort.Sort();

            for (int i = 0; i < RandomItems.Count; i++)
            {
                Assert.AreEqual(Sorted[i], defautSort[i]);
            }
        }

        [TestMethod()]
        public void SelectionSortTest()
        {
            var selectionSort = new SelectionSort<int>();

            selectionSort.Items.AddRange(RandomItems);

            selectionSort.Sort();

            for (int i = 0; i < RandomItems.Count; i++)
            {
                Assert.AreEqual(Sorted[i], selectionSort.Items[i]);
            }
        }

        [TestMethod()]
        public void BubbleSortTest()
        {
            var bubbleSort = new BubbleSort<int>();

            bubbleSort.Items.AddRange(RandomItems);

            bubbleSort.Sort();

            for (int i = 0; i < RandomItems.Count; i++)
            {
                Assert.AreEqual(Sorted[i], bubbleSort.Items[i]);
            }
        }

        [TestMethod()]
        public void RadixSortTest()
        {
            var radixSort = new RadixSort<int>();

            radixSort.Items.AddRange(RandomItems);

            radixSort.Sort();

            for (int i = 0; i < RandomItems.Count; i++)
            {
                Assert.AreEqual(Sorted[i], radixSort.Items[i]);
            }
        }

        [TestMethod()]
        public void MergeSortTest()
        {
            var mergeSort = new MergeSort<int>();

            mergeSort.Items.AddRange(RandomItems);

            mergeSort.Sort();

            for (int i = 0; i < RandomItems.Count; i++)
            {
                Assert.AreEqual(Sorted[i], mergeSort.Items[i]);
            }
        }

        [TestMethod()]
        public void QuickSortTest()
        {
            var quickSort = new QuickSort<int>();

            quickSort.Items.AddRange(RandomItems);

            quickSort.Sort();

            for (int i = 0; i < RandomItems.Count; i++)
            {
                Assert.AreEqual(Sorted[i], quickSort.Items[i]);
            }
        }
    }
}