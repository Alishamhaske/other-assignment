using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopfirstclass_program.assignment
{
    public class squ
    {
        static void Main(string[] args)
        {
            square s1 = new square();
            s1.squ1();
          
            Console.WriteLine(s1.squ2());
            s1.squ3(4);

            Console.WriteLine(s1.squ4(9));

        }
    }

    //write a program to calculate square for given number using no return type ,with return type,
   // with parameter passing, with parameter and return type.
    public class square
    {
        private int a = 32;

        public void squ1()
        {
            int s = a * a;
            Console.WriteLine("square is: "+s);
        }

        //with return type
        public int squ2()
        {
            int s = a * a;
            return s;
        }
        //with parameter passing

        public void squ3(int a)
        {
            int s = a * a;
            Console.WriteLine("square with parameter: "+s);
        }

        //with parameter and with return type

        public string squ4(int a)
        {
            int s = a * a;
            return $"sqaure using with parameter and with return type {s}";
        }
        


    }

}
