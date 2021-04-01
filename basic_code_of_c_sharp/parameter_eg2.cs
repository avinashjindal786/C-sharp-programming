using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first_program
{
    class parameter_eg2
    {
        int x;
        public parameter_eg2(int a)
        {
            x = a; 
            Console.WriteLine("print value a" + " " + a);
        }

        public void display()
        {
            Console.WriteLine("print the value x" + " " + x);
        }
    }
}
