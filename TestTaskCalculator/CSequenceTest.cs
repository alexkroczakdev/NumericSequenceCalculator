using Microsoft.VisualStudio.TestTools.UnitTesting;
using TaskCalculator.BuisnessLayer;

namespace TestTaskCalculator
{
    [TestClass]
    public class CSequenceTest
    {
        [TestMethod]
        public void Calculate_AllNumbersUpToNumberEnteredWithInput()
        {
            var cSequence = new CSequence();

            var result = cSequence.Calculate(7);

            Assert.AreEqual("1 2 3 4 5 6 7", result);
        }

        [TestMethod]
        public void Calculate_3IfNumberIsMultipleOf3()
        {
            var cSequence = new CSequence();

            var result = cSequence.Calculate(12);

            Assert.AreEqual("C", result);
        }
    }
}
