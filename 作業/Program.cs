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
            Console.WriteLine(string.Join(",", Console.ReadLine().Split(',').Reverse()));
            

        }
    }
}
