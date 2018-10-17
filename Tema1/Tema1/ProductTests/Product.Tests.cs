using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Products = Product.Data;
namespace ProductTests
{
    [TestClass]
    public class ProductTest
    {
        [TestInitialize]
        public void Product()
        {
            SUT.StartDate = DateTime.Now;
            SUT.EndDate = DateTime.Now.AddYears(2);
        }
        public Products.Product SUT = new Products.Product();

        [TestMethod]
        public void IsValid()
        {
            Assert.IsTrue(this.SUT.IsValid());
        }
        [TestMethod]
        public void IsInvalid()
        {
            SUT.StartDate = DateTime.Now;
            SUT.EndDate = DateTime.Now.AddYears(-2);
            Assert.IsFalse(this.SUT.IsValid());
        }
        [TestMethod]
        public void VatPriceIsRight()
        {
            SUT.Price = 30;
            SUT.VAT = 50;
            Assert.AreEqual(this.SUT.ComputeVAT(), 45);
        }

    }
}
