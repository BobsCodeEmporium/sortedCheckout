using System;
using System.Collections.Generic;
using System.Linq;

namespace sortedBasket
{
    public class Basket
    {
        private List<Item> _internalBasket = new List<Item>();
        private List<Offers> _offers;

        public Basket()
        {
            _offers = new List<Offers>
            {
                new Offers { Item = new Item { Sku = "A99", UnitPrice = 0.5m }, OfferMultiplier = 3, OfferPrice = 1.3m },
                new Offers { Item = new Item { Sku = "B15", UnitPrice = 0.3m }, OfferMultiplier = 2, OfferPrice = 0.45m }
            };

        }

        public bool Scan(Item item)
        {
            _internalBasket.Add(item);
            return true;
        }

        public object Total()
        {
            var total = 0m;

            foreach (var item in _internalBasket)
            {
                total += item.UnitPrice;
            }

            foreach (var offer in _offers)
            {
                if (_internalBasket.Count(x => x.Sku == offer.Item.Sku) >= offer.OfferMultiplier)
                {
                    var qualifyingItems = _internalBasket.Count(x => x.Sku == offer.Item.Sku) / offer.OfferMultiplier;
                    total = total - offer.Item.UnitPrice * offer.OfferMultiplier;
                    total += offer.OfferPrice * qualifyingItems;
                }
            }

            return total;
        }
    }
}
