using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class PettyCash
    {
        PettyCashProtected realThing = new PettyCashProtected();
        Person p = new Person();
        public
    bool withdraw(int i, int amount)
        {
            if (p.name(i) == "Tom" || p.name(i) == "Harry" || p.name(i) == "Bubba")
                return realThing.withdraw(amount);
            else
                return false;
        }
        public
        int getBalance()
        {
            return realThing.getBalance();
        }
    }
}
