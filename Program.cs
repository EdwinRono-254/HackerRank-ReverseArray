using System;
using System.Collections.Generic;
using System.Linq;

namespace HackerRank_ReverseArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            int[] reverse = Enumerable.Reverse(arr).ToArray();
            Console.WriteLine(String.Join(' ', reverse));
        }
    }
}
