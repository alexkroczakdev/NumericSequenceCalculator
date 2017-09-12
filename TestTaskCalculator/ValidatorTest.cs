using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TaskCalculator.BuisnessLayer;

namespace TestTaskCalculator
{
    [TestClass]
    public class ValidatorTest
    {
        [TestMethod]
        public void ValidateInputNumber_AcceptPositiveNumbers()
        {
            //arrange
            bool result = false;
            var validator = new ValidateNumber();

            //act
            result = validator.ValidateInputNumber(5);

            //assert
            Assert.IsTrue(result, "Given number is positive");
        }

        [TestMethod]
        public void ValidateInputNumber_AcceptWholeNumbers()
        {
            //arrange
            bool result = false;
            var validator = new ValidateNumber();

            //act
            result = validator.ValidateInputNumber(0);

            //assert
            Assert.IsFalse(result, "Given number is not whole number");
        }
    }
}
