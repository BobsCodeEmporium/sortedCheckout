using System;
using System.Collections.Generic;

namespace sortedBasket
{
    public class Basket
    {
        private List<Item> internalBasket = new List<Item>();

        public bool Scan(Item item)
        {
            internalBasket.Add(item);
            return true;
        }
    }
}
