using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopfirstclass_program.assignment
{
    public class arthmethic
    {
        static void Main(string[] args)
        {
            arthmethicop a = new arthmethicop();
            Console.WriteLine("enter two parameter");
            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());
            a.add(x, y);
            Console.WriteLine( a.display());
            a.sub(x, y);
            Console.WriteLine(a.display());
            a.mul(x, y);
            Console.WriteLine(a.display());
            a.div(x, y);
            Console.WriteLine(a.display());


        }
    }

    //8)Write  Program for arithmetic  operation for each operation write separate Method.

    public class arthmethicop
    {
     
        public int c;
        

        public int add(int a, int b)
        {
            c = a + b;
            return c;
        }
        public int sub(int a,int b)
        {
             c = a - b;
            return c;
        }
        public int mul(int a,int b)
        {
             c = a * b;
            return c;
        }
        public int div(int a,int b)
        {
             c= a / b;
            return c;
        }
        public string display()
        {
            return $"{c} ";
        }
    }
}
