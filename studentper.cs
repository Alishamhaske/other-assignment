using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopfirstclass_program.assignment
{
    public class studentper
    {
        static void Main(string[] args)
        {
            student st1 = new student();
           
            Console.WriteLine("persentage with return type method "+st1.persen());
            st1.persen1();

        }
    }

    //7) Create class student and write a meaningful program
    //with 3 methods (1 with return type (calculating percentage), 1 without return

    class student
    {
        
        public int math = 90;
        public int marathi = 78;
        public int eng = 76;

        public double persen()
        {
            double per = (math + marathi + eng) / 3;
            return per;
        }
        public void persen1()
        {
            double per= (math + marathi + eng) / 3;
            Console.WriteLine("persentage is "+per);
        }
       
    }
}
