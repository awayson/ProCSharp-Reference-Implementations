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
        
        // Static Properties
        public static void SetInterestRate(double newRate) => currInterestRate = newRate;
        public static double GetInterestRate() => currInterestRate;

        // Field
        public double currBalance;
        
        // Constructor
        public SavingsAccount(double balance)
        {
            currBalance = balance;
        }
    }
}
