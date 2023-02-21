using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 作業
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("輸入一串數字由逗號間隔");
            string user=Console.ReadLine();
            List<int> list= new List<int>();
            var ints = user.Split(',').Select(int.Parse).ToList().OrderByDescending(x=>x);
            string afterOrder="";
            foreach (int i in ints) { afterOrder += (i + ","); }
            Console.WriteLine(afterOrder.TrimEnd(','));
        }
    }
}
