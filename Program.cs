using System.Net.Http.Headers;

namespace CsharpApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] numTab = new int[3] { 5, 2, 6 };
            //string[] strTab = new string[] { "ZS", "Kocjan" };
            //for (int i = 0; i < numTab.Length; i++)
            //{
            //    Console.WriteLine(numTab[i]);

            //}
            //foreach (int j in numTab)
            //{
            //    Console.WriteLine("{0} ", j);
            //}
            //foreach (string txt in strTab)
            //{
            //    Console.Write($"{txt} ");
            //}
            int[] nums = { 56, 2, 33, 47, 5 };
            Console.WriteLine("Tablica nieposortowana: ");
            foreach (int i in nums)
            {
                Console.Write($"{i} ");

            }
            
            Array.Sort(nums);
            Console.WriteLine("\nTablica posortowana");
            foreach (int item in nums)
            {
                Console.Write(item + " ");
            }
            Array.Reverse(nums);
            Console.WriteLine("\nTablica sort. odwrócona ");
            foreach (int item1 in nums)
            {
                Console.Write(item1 + " ");
            }
            Console.WriteLine("\nMax element: " + nums.Max());
            Console.WriteLine("Min elemnt: " + nums.Min());

            float sum = nums.Sum();
            int count = nums.Count();
            float avg = sum / count;
            Console.WriteLine("Srednia tablicy: {0}", avg );
            Console.WriteLine("Srednia z metody: " + nums.Average());
        }
    }
}