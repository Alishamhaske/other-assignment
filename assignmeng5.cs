using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopfirstclass_program.assignment
{
    public class assignmeng5
    {
        static void Main(string[] args)
        {
            assign5 a5 = new assign5();
            a5.accpect(2, "pashya");
            Console.WriteLine(a5.display());

        }
    }

    //5) Write a program for class and object : (initialization through method)
   // Note : Initializing object simply means storing data into object

    class assign5
    {
        public int id;
        public string name;
        public void accpect(int id, string name)
        {
            this.id = id;
            this.name = name;
        }
        public string display()
        {
            return $"{id} {name}";
        }

    }

}
