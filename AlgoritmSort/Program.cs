namespace AlgoritmSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var list = new List<int>() { 1,3,5,2,6,8,1,4,9,3};

            var randomList = new List<int>();


            var mySort = new SelectionSort<int>();

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