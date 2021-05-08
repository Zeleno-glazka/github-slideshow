using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class PettyCashProtected
    {
        int balance;
        public
    PettyCashProtected()
        {
            balance = 500;
        }

        public 
            bool withdraw(int amount)
        {
            if (amount > balance)
                return false;
            balance -= amount;
            return true;
        }
        public
         int getBalance()
        {
            return balance;
        }
    }
}
