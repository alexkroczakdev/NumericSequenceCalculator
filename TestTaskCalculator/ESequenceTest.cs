using Microsoft.VisualStudio.TestTools.UnitTesting;
using TaskCalculator.BuisnessLayer;

namespace TestTaskCalculator
{
    [TestClass]
    public class ESequenceTest
    {
        [TestMethod]
        public void Calculate_AllNumbersUpToNumberEnteredWithInput()
        {
            var eSequence = new ESequence();

            var result = eSequence.Calculate(7);

            Assert.AreEqual("1 2 3 4 5 6 7", result);
        }

        [TestMethod]
        public void Calculate_3IfNumberIsMultipleOf5()
        {
            var eSequence = new ESequence();

            var result = eSequence.Calculate(10);

            Assert.AreEqual("E", result);
        }
    }
}
