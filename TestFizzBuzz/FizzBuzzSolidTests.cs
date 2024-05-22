using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestFizzBuzz
{
    [TestClass]
    public class FizzBuzzSolidTests
    {
        private FizzBuzzController fizzBuzzController;

        [TestInitialize]
        public void TestInitialize()
        {
            fizzBuzzController = new FizzBuzzController();
        }

        [TestMethod]
        public void FizzBuzzSolidTest_OneResult()
        {
            var result = fizzBuzzController.PrintList(1);

            Assert.AreEqual(result[0], "1");
        }

        [TestMethod]
        public void FizzBuzzSolidTest_10Results()
        {
            var result = fizzBuzzController.PrintList(1);

            Assert.AreEqual(result[2], "Fizz");
            Assert.AreEqual(result[4], "Buzz");
        }
    }
}
