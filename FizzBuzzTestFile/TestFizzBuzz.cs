using FizzBuzzSolid;

namespace FizzBuzzTestFile
{
    [TestClass]
    public class TestFizzBuzz
    {
        FizzBuzzController fizzBuzzController;

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
        public void FizzBuzzSolidTest_15Results()
        {
            var result = fizzBuzzController.PrintList(15);

            Assert.AreEqual(result[0], "1");
            Assert.AreEqual(result[2], "Fizz");
            Assert.AreEqual(result[4], "Buzz");
            Assert.AreEqual(result[13], "14");
            Assert.AreEqual(result[14], "FizzBuzz");
        }
    }
}