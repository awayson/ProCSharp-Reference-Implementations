using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticDataAndMembers
{
    class SavingsAccount
    {
        // Static field
        public static double currInterestRate = 0.04;

        // Field
        public double currBalance;

        public static double GetInterestRate()
        {
            return currInterestRate;
        }
        
        // Constructor
        public SavingsAccount(double balance)
        {
            currBalance = balance;
        }
    }
}
