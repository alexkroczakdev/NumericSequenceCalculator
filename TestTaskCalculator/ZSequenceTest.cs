using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TaskCalculator.BuisnessLayer;
using System.Collections.Generic;

namespace TestTaskCalculator
{
    [TestClass]
    public class ZSequenceTest
    {
        [TestMethod]
        public void Calculate_AllNumbersUpToNumberEnteredWithInput()
        {
            var zSequence = new ZSequence();

            var result = zSequence.Calculate(7);

            Assert.AreEqual("1 2 3 4 5 6 7", result);
        }


        [TestMethod]
        public void Calculate_AllNumbersUpToNumberEnteredWithInputMultipleOf5()
        {
            var zSequence = new ZSequence();

            var result = zSequence.Calculate(10);

            Assert.AreEqual("1 2 3 4 5 6 7 8 9 10", result);
        }

        [TestMethod]
        public void Calculate_AllNumbersUpToNumberEnteredWithInputMultipleOf3()
        {
            var zSequence = new ZSequence();

            var result = zSequence.Calculate(6);

            Assert.AreEqual("1 2 3 4 5 6", result);
        }

        [TestMethod]
        public void Calculate_3IfNumberIsMultipleOf3and5()
        {
            var zSequence = new ZSequence();

            var result = zSequence.Calculate(15);

            Assert.AreEqual("Z", result);
        }        
    }
}
