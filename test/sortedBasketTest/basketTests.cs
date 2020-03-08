using System;
using Xunit;

namespace sortedBasketTest
{
    public class basketTests
    {
        [Fact]
        public void WhenAnItemIsScannedItIsAddedToTheBasket()
        {
            //Arrange
            var basket = new sortedBasket.Basket();
            var item = new sortedBasket.Item { Sku = "A99", UnitPrice = 0.5m };

            //Act
            var status = basket.Scan(item);

            //Assert
            Assert.True(status);
        }

        [Fact]
        public void WhenATotalIsRequestedItIsReturned()
        {

        }

        [Fact]
        public void WhenAnOfferIsAvailableItIsApplied()
        {

        }
    }
}
