namespace AlgoritmSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //manual testing
            var list = new List<int>() { 1,32,5,2,6,8,1,4,91,322, 10};

            var randomList = new List<int>();

            var mySort = new MergeSort<int>();

            mySort.Items.AddRange(list);
            mySort.Sort();

            Console.WriteLine($"Count swap = {mySort.countSwap}");
            foreach (int i in mySort.Items) 
            {
                Console.Write($"{i}, ");
            }
            Console.WriteLine("\n\n");
        }
    }
}