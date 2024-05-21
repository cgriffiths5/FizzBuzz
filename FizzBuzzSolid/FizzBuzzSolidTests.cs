using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;

namespace FizzBuzzSolid
{
    [TestClass]
    public class FizzBuzzSolidTests
    {
        private StringWriter _stringWriter;
        private FizzBuzzController fizzBuzzController;

        [TestInitialize]
        public void TestInitialize()
        {
            _stringWriter = new StringWriter();
            Console.SetOut(_stringWriter);
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
