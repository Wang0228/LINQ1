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
            string odd = "", even = "";

            Console.WriteLine("奇數:");
            foreach(int x in list_odd) { odd+=(x+","); }
            Console.WriteLine(odd.TrimEnd(','));
            Console.WriteLine("\n偶數:");
            foreach (int x in list_even) { even += (x + ","); }
            Console.WriteLine(even.TrimEnd(','));
        }
    }
}
