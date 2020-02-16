using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodDesignPattern
{
    class PlatinumFactory : CreditCardFactory
    {
        protected override CreditCard MakeProduct()
        {
            CreditCard creditCard = new Platinum();
            return creditCard;
        }
    }
}
