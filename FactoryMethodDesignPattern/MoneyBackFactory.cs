using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodDesignPattern
{
    class MoneyBackFactory: CreditCardFactory   
    {
        protected override CreditCard MakeProduct()
        {
            CreditCard creditCard = new MoneyBack();
            return creditCard;
        }

    }
}
