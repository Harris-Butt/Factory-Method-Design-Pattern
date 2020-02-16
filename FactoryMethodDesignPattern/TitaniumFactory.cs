using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodDesignPattern
{
    class TitaniumFactory: CreditCardFactory
    {
        protected override CreditCard MakeProduct()
        {
            CreditCard creditCard = new Titanium();
            return creditCard;

        }
        
    }
}
