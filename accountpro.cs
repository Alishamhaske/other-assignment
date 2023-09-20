using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopfirstclass_program.assignment
{
    public class accountpro
    {
        static void Main(string[] args)
        {
            account a1 = new account();
            a1.insert(5000, 101);
            Console.WriteLine(a1.display());
            Console.WriteLine("Enter withdraw amount");
            double w_amt = Convert.ToDouble(Console.ReadLine());
            a1.withdraw(w_amt);
            Console.WriteLine(a1.display());

           Console.WriteLine("enter deposite amount");
            double d_amt = Convert.ToDouble(Console.ReadLine());
            a1.deposit(d_amt);
           Console.WriteLine(a1.display());

           

            a1.checkbal();
            Console.WriteLine(a1.display());
        }
    }

    
    /* Create a class Account containing following methods :
insert() to insert account data
display() to display account information
deposit() to deposit amount
withdraw() to withdraw amount
checkbalance() to check balance*/

   public class account
   {
       public  int acc_no;
       
       public double amount, dep_amt;

        public void insert(double amount, int acc_no)
        {
            
            this.amount = amount;
            this.acc_no = acc_no;


        }
        public string display()
        {
            return $"Accont: {acc_no}, Amount: {amount}";
        }

        public void withdraw(double wid_amt)
        {

            if (amount > wid_amt)
            {
                amount = amount -wid_amt;
                Console.WriteLine("remaining balance:" + amount);
            }
            else
            {
                Console.WriteLine("not suffient balance");
            }
        }

        public void deposit(double dep_amt)
        {
           
            if(dep_amt!=0)
            {
                 amount =amount+ dep_amt;
                Console.WriteLine("total balance is:"+amount);
            }
            else
            {
                Console.WriteLine("invalid");
            }
        }

        

        public void checkbal()
        {
            
            Console.WriteLine("balance is:"+amount);
        }
        
    }



}
