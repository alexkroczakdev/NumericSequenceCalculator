using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TaskCalculator.BuisnessLayer;
using System.Collections.Generic;

namespace TestTaskCalculator
{
    [TestClass]
    public class ZCESequenceTest
    {
        [TestMethod]
        public void Calculate_AllNumbersUpToNumberEnteredWithInput()
        {
            var zceSequence = new ZCESequence();

            var result = zceSequence.Calculate(7);

            Assert.AreEqual("1 2 3 4 5 6 7", result);
        }


        [TestMethod]
        public void Calculate_AllNumbersUpToNumberEnteredWithInputMultipleOf5()
        {
            var zceSequence = new ZCESequence();

            var result = zceSequence.Calculate(10);

            Assert.AreEqual("E", result);
        }

        [TestMethod]
        public void Calculate_AllNumbersUpToNumberEnteredWithInputMultipleOf3()
        {
            var zceSequence = new ZCESequence();

            var result = zceSequence.Calculate(6);

            Assert.AreEqual("C", result);
        }

        [TestMethod]
        public void Calculate_3IfNumberIsMultipleOf3and5()
        {
            var zceSequence = new ZCESequence();

            var result = zceSequence.Calculate(15);

            Assert.AreEqual("Z", result);
        }        
    }
}
