using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodDesignPattern
{
    class Titanium : CreditCard
    {
        public int GetAnnualCharge()
        {
            return 500;
        }

        public string GetCardType()
        {
            return "Titanium";
        }

        public int GetCreditCardLimit()
        {
            return 150000;
        }
    }
}
