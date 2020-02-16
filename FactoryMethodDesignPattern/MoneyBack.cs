using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodDesignPattern
{
    class MoneyBack : CreditCard
    {
        public int GetAnnualCharge()
        {
            return 100;
        }

        public string GetCardType()
        {
            return "Money Back";
        }

        public int GetCreditCardLimit()
        {
            return 100000;
        }
    }
}
