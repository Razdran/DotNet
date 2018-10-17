using Managers = Product.Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ProductTests

{
    [TestClass]
    public class ManagerTest
    {
        [TestInitialize]
        public void Manager()
        {
            SUT.FirstName = "Mart";
            SUT.LastName = "Florin";
            SUT.EndDate = DateTime.Now.AddYears(2);
        }
        public Managers.Manager SUT = new Managers.Manager();
        [TestMethod]
        public void CheckFullName()
        {
            Assert.AreEqual("Mart Florin",SUT.GetFullName());
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
