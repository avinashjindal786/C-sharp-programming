using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first_program
{
    class copy_cons
    {
        int x;
        public copy_cons(int a)
        {
            x = a;
        }

        public copy_cons(copy_cons T)
        {
            x = T.x;
        }
        public void display()
        {
            Console.WriteLine("print the value x" + " " + x);
        }
    }
}
