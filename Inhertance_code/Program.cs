using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace second_prog
{
    class Program:extra
    {
        static void Main(string[] args)
        {
            Program c = new Program();
            c.test1();
            c.test2(10);
            
            Console.ReadLine();
        }
        
       /* public new void test2()
        {
            Console.WriteLine("overhiding Method2");
        }*/
    }
}
