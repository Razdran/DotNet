using System;
using Xunit;
using Products = Product.Data;

namespace Product.xUnit.Tests
{
    public class ProductTests
    {
        public ProductTests()
        {
            
            SUT.StartDate = DateTime.Now;
            SUT.EndDate = DateTime.Now.AddYears(2);
        }
        public Products.Product SUT = new Products.Product();
        [Fact]
        public void IsValid()
        {
            Assert.True(this.SUT.IsValid());
        }
        [Fact]
        public void IsInvalid()
        {
            SUT.StartDate = DateTime.Now;
            SUT.EndDate = DateTime.Now.AddYears(-2);
            Assert.False(this.SUT.IsValid());
        }
        [Fact]
        public void VatPriceIsRight()
        {
            SUT.Price = 30;
            SUT.VAT = 50;
            Assert.Equal(45, this.SUT.ComputeVAT());
        }
    }
}
