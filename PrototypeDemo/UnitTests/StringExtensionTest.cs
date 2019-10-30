using System;
using LoginHandling.Extensions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTests
{
    [TestClass]
    public class StringExtensionTest
    {
        [TestMethod]
        public void ContainsUpperLowerNumber_DontContainNumber_False()
        {
            //Arrange
            string str = "AsdasdAd";

            //Act
            var result = str.ContainsUpperLowerNumber();

            //Assert
            Assert.AreEqual(false, result);
        }

        [TestMethod]
        public void ContainsUpperLowerNumber_ContainsEverything_True()
        {
            //Arrange
            string str = "Aa12dA";

            //Act
            var result = str.ContainsUpperLowerNumber();

            //Asert
            Assert.IsTrue(result);
        }
    }
}
