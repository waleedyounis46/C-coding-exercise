using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Instantiate Account class
            Account account = new Account();
            double currentamount = 0.0;
            // save money in current account
            currentamount = account.setaccountbalance(1000.00);
            Console.WriteLine("current amount : {0}", currentamount);

            //withdraw
            currentamount = account.withdrawFromaccount(200);
            Console.WriteLine("current amount : {0}", currentamount);

            //balance
            currentamount = account.getaccountbalance();
            Console.WriteLine("current amount: {0}", currentamount);
            Console.ReadLine();
        }
    }
}
