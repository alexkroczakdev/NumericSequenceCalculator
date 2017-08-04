using Microsoft.VisualStudio.TestTools.UnitTesting;
using TaskCalculator.BuisnessLayer;

namespace TestTaskCalculator
{
    [TestClass]
    public class EvenSequenceTest
    {
        [TestMethod]
        public void Calculate_AllEvenNumbersUpToNumberEnteredWithEvenInput()
        {
            var oddSequence = new EvenSequence();

            var result = oddSequence.Calculate(6);

            Assert.AreEqual("2 4 6", result);

        }

        [TestMethod]
        public void Calculate_AllEvenNumbersUpToNumberEnteredWithOddInput()
        {
            var oddSequence = new EvenSequence();

            var result = oddSequence.Calculate(7);

            Assert.AreEqual("2 4 6 7", result);

        }
    }
}
