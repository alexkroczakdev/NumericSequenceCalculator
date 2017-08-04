using Microsoft.VisualStudio.TestTools.UnitTesting;
using TaskCalculator.BuisnessLayer;

namespace TestTaskCalculator
{
    [TestClass]
    public class FibonacciSequenceTest
    {
        [TestMethod]
        public void Calculate_GetFibonacciNumber()
        {
            var fibonacci = new FibonacciSequence();

            var result = fibonacci.Calculate(5);

            Assert.AreEqual("1 1 2 3 5", result);
        }

        [TestMethod]
        public void Calculate_GetFibonacciNumberWhenNotInFibonacci()
        {
            var fibonacci = new FibonacciSequence();

            var result = fibonacci.Calculate(9);

            Assert.AreEqual("1 1 2 3 5 8 9", result);
        }
    }
}
