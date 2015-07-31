using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Library {
    [TestClass]
    public class StringExtensionsTester {
        [TestMethod]
        public void TestTitleCaseConversion () {
            //Arrange 
            var source          = "the return of the king";
            var expectedResult  = "The Return Of The King";

            //Act
            //var actualResult    = StringExtensions.ConvertToTitleCase(source);
            var actualResult = source.ConvertToTitleCase();

            //Assert
            Assert.IsNotNull(actualResult);
            Assert.AreEqual(actualResult, expectedResult);
        }
    }
}
