using Arhitects = Product.Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ProductTests

{
    [TestClass]
    public class ArhitectTest
    {
        [TestInitialize]
        public void Arhitect()
        {
            SUT.FirstName = "Mart";
            SUT.LastName = "Florin";
            SUT.EndDate = DateTime.Now.AddYears(2);
        }
        public Arhitects.Employee SUT = new Arhitects.Arhitect();
        [TestMethod]
        public void CheckFullName()
        {
            Assert.AreEqual("Mart Florin", SUT.GetFullName());
        }
        [TestMethod]
        public void isActive()
        {
            Assert.IsTrue(this.SUT.IsActive());
        }
        [TestMethod]
        public void isInactive()
        {
            SUT.EndDate = DateTime.Now.AddYears(-2);
            Assert.IsFalse(this.SUT.IsActive());
        }
    }
}
