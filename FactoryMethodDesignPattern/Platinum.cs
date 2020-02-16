using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodDesignPattern
{
    class Platinum : CreditCard
    {
        public int GetAnnualCharge()
        {
            return 1000;
        }

        public string GetCardType()
        {
            return "Platinum";
        }

        public int GetCreditCardLimit()
        {
            return 200000;
        }
    }
}
