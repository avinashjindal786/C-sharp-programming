using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;  

namespace first_program
{
    class Program
    {
        static void Main(string[] args)
        {
            hello_world c1 = new hello_world();     // used hello_world file
            
            implict c2 = new implict();                  // used implict file
            //  c2.implict1();                       // method of implict file
            
            explict c3 = new explict();              // used explict file
                                                     //  c3.explict1();                           // method of implict file

            parameteric_eg1 c4 = new parameteric_eg1(10);

            parameter_eg2 c5 = new parameter_eg2(100);
            //  c5.display();

            copy_cons c6 = new copy_cons(1100);
            copy_cons c7 = new copy_cons(c6);
            c7.display();

            stat c8 = new stat();

            Console.WriteLine("My name is avinash jindal");
            Console.ReadLine();
        }
    }
}
