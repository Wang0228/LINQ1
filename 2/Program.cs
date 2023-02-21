using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("輸入由逗號隔開的數列");
            string numString = Console.ReadLine();
            
            IOrderedEnumerable<int> list_odd =  numString.Split(',').Where(x => Convert.ToInt32(x) % 2 != 0).Select(int.Parse).ToList().OrderBy(x=>x);
            IOrderedEnumerable<int> list_even = numString.Split(',').Where(x => Convert.ToInt32(x) % 2 == 0).Select(int.Parse).ToList().OrderBy(x=>x);
            Console.Write("奇數:");
            Console.WriteLine(string.Join(",", list_odd));
            Console.Write("偶數:");
            Console.WriteLine(string.Join(",", list_even));
        }
    }
}
