using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using TaskCalculator.BuisnessLayer;

namespace TestTaskCalculator
{
    [TestClass]
    public class OddSequenceTest
    {
        [TestMethod]
        public void Calculate_AllOddNumbersUpToNumberEnteredWithEvenInput()
        {
            var oddSequence = new OddSequence();

            var result = oddSequence.Calculate(6);

            Assert.AreEqual("1 3 5 6", result);

        }

        [TestMethod]
        public void Calculate_AllOddNumbersUpToNumberEnteredWithOddInput()
        {
            var oddSequence = new OddSequence();

            var result = oddSequence.Calculate(7);

            Assert.AreEqual("1 3 5 7", result);

        }
    }
}
