using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using TaskCalculator.BuisnessLayer;

namespace TestTaskCalculator
{
    [TestClass]
    public class SequenceTest
    {
        [TestMethod]
        public void Calculate_AllNumbersUpToNumberEntered()
        {
            var sequence = new Sequence();

            var result = sequence.Calculate(8);

            Assert.AreEqual("1 2 3 4 5 6 7 8",result );
        }
    }
}
