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

        public object Total()
        {
            var total = 0m;

            foreach (var item in internalBasket)
            {
                total += item.UnitPrice;
            }

            return total;
        }
    }
}
