using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopfirstclass_program.assignment
{
    public class cubepro
    {
        static void Main(string[] args)
        {
            cube c1 = new cube();
            c1.cube1();
            Console.WriteLine(c1.cube2());
            c1.cube3(7);
            Console.WriteLine(c1.cube4(9));

        }
    }

    //12) write a program to calculate cube for given number using no return type ,with return type,
    //with parameter passing, with parameter and return type.

    class cube
    {
        public int n = 8;

        //no return type no parameter
        public void cube1()
        {
            Console.WriteLine("cube is: "+n*n*n);
        }
        //with return type
        public string cube2()
        {
            int c = n * n * n;
            return $"cube using return type{c}";
        }
        //with parameter
        public void cube3(int a)
        {
            int c = a * a * a;
            Console.WriteLine("cube with parametr "+c);
        }
        //with parameter with return type
        public string cube4(int a)
        {
            int c = a * a * a;
            return $"cube using with parameter with return type: {c}";
        }
    }
}
