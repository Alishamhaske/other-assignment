using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace oopfirstclass_program.assignment
{
    public class studentclass
    {
        static void Main(string[] args)
        {
            studentcustom s1 = new studentcustom(2,"tanu");
            s1.setCustomData(2, "Samruddhi");
            Console.WriteLine(s1.display());

        }
    }

    /*create another method in Student class setCustomData(int
    customId, String customName) These 2 variables are local
    variables.Call setCustomData from main method using
     Student object and assign any values to customId,
     customName from main method.Observe your values are
       overwritten in id and name instance variables.Then print
       id and name in main method.*/


    class studentcustom
    {
        private int customid;
        private string customname;

        public studentcustom(int customid,string customname)
        {
            this.customid = customid;
            this.customname =customname;
        }
        public string setCustomData(int customid,string customname)
        {
            this.customid = customid;
            this.customname = customname;
            return $"{customid} {customname}";
        }

        public string display()
        {
            return $"{customid}{customname}";
        }
       

    }


}
