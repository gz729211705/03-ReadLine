using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_ReadLine
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "梦晓，你喜欢吃啥字？";
            Console.WriteLine(str); 
            string b = Console.ReadLine();
            Console.WriteLine("我喜欢吃你喜欢吃的{0}", b);
            Console.ReadKey();
        }
    }
}
