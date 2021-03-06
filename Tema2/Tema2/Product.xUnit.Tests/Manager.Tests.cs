﻿using System;
using Xunit;
using Product.Data;

namespace Product.xUnit.Tests
{
    public class ManagerTests
    {
        public ManagerTests()
        {
            SUT.FirstName = "Mart";
            SUT.LastName = "Florin";
            SUT.StartDate = DateTime.Now;
            SUT.EndDate = DateTime.Now.AddYears(2);
        }
        public Employee SUT = new Manager();
        [Fact]
        public void CheckFullName()
        {
            Assert.Equal("Mart Florin", SUT.GetFullName());
        }
        [Fact]
        public void isActive()
        {

            Assert.True(this.SUT.IsActive());
        }
        [Fact]
        public void isInactive()
        {
            SUT.EndDate = DateTime.Now.AddYears(-2);
            Assert.False(this.SUT.IsActive());
        }
        [Fact]
        public void salutation()
        {
            Assert.Equal(SUT.Salutation(), "Hello Manager");
        }
    }
}
