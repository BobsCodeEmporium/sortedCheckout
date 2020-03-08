using System;
using Xunit;

namespace sortedBasketTest
{
    public class basketTests
    {
        private readonly sortedBasket.Item _biscuits = new sortedBasket.Item { Sku = "B15", UnitPrice = 0.3m };
        private readonly sortedBasket.Item _apple = new sortedBasket.Item { Sku = "B15", UnitPrice = 0.5m };
        private readonly sortedBasket.Item _banana = new sortedBasket.Item { Sku = "B15", UnitPrice = 0.6m };


        [Fact]
        public void WhenAnItemIsScannedItIsAddedToTheBasket()
        {
            //Arrange
            var basket = new sortedBasket.Basket();
            
            //Act
            var status = basket.Scan(_apple);

            //Assert
            Assert.True(status);
        }

        [Fact]
        public void WhenATotalIsRequestedItIsReturned()
        {
            //Arrange
            var basket = new sortedBasket.Basket();
            basket.Scan(_apple);

            //Act
            var total = basket.Total();

            //Assert
            Assert.Equal(0.5m, total);
        }

        [Fact]
        public void WhenAnOfferIsAvailableItIsApplied()
        {
            //Arrange
            var basket = new sortedBasket.Basket();

            //Act
            basket.Scan(_biscuits);
            basket.Scan(_biscuits);

            var total = basket.Total();

            //Assert
            Assert.Equal(.45m, total);
        }
    }
}
