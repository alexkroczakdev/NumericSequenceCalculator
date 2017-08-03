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
            result = validator.ValidateInputNumber(-5);

            //assert
            Assert.IsFalse(result, "Given number is negative");
        }

        [TestMethod]
        public void ValidateInputNumber_AcceptWholeNumbers()
        {
            //arrange
            bool result = false;
            var validator = new ValidateNumber();

            //act
            result = validator.ValidateInputNumber(5.3);

            //assert
            Assert.IsFalse(result, "Given number is not whole number");
        }

        [TestMethod]
        public void ValidateInputNumber_NotAcceptNulls()
        {
            //arrange
            bool result = false;
            var validator = new ValidateNumber();

            //act
            result = validator.ValidateInputNumber(null);

            //assert
            Assert.IsFalse(result, "Given number is null");
        }
    }
}
