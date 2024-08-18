using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticDataAndMembers
{
    class SavingsAccountWithStaticProperties
    {
        private static double _currInterestRate = 0.04;

        public double currBalance;

        public static double InterestRate
        {
            get { return _currInterestRate; }
            set { _currInterestRate = value; }
        }
    }
}
