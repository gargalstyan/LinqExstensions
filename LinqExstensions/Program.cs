namespace LinqExstensions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] ints = new int[] { 1, 3, 3, 3, -4, -4 };
            List<int> ints1 = new List<int>() { -2, -1, 4, 1, 6, 7, 8,1,-3,2 };
            string[] names = new string[] { "Jhon", "Tom", "Jack" };
            string[] strings = new string[] { "jhon", "Gago", "Hamo" };
            foreach (var item in ints1.SkipWhile(i => i < 2))
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("////////////////////////////");
            foreach (var item in ints1.MySkipWhile(i => i < 2))
            {
                Console.WriteLine(item);
            }

        }
    }
}