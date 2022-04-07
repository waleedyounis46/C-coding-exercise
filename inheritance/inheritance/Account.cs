using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    internal class Account : Person
    {
        //Constructor
        public Account() { }
        public double getaccountbalance()
        {
            return currentAccount;
        }
        public double setaccountbalance (double amount)
        {
            currentAccount = currentAccount + amount;
            return currentAccount;
        }
        public double withdrawFromaccount (double amountFromWithdraw)
        {
            currentAccount = currentAccount - amountFromWithdraw;
            return currentAccount;
        }

    }
}
