namespace LinqExstensions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] ints = new int[] { 1, 3, 4, 5, 5, 7, 11, 12, 13, -4, -4 };
            List<int> ints1 = new List<int>() { -2, -1, 4, 1, 6, 7, 8,1, -3, 2 };
            string[] names = new string[] { "Jhon", "Tom", "Jack" };
            string[] strings = new string[] { "jhon", "Gago", "Hamo" };
            Console.WriteLine("All");
            Console.WriteLine(ints1.MyAll(i=>i>-4));
            Console.WriteLine("///////////////////////////");
            Console.WriteLine("Any");
            Console.WriteLine(ints1.MyAny(i=>i>111));
            Console.WriteLine("//////////////////////////");
            Console.WriteLine("Single");
            Console.WriteLine(ints1.MySingle(i => i > 7));
            Console.WriteLine("////////////////////////////");
            Console.WriteLine("Except");
            foreach (var item in ints.MyExcept(ints1))
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