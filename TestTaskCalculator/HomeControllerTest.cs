using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskCalculator.Controllers;

namespace TestTaskCalculator
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void CheckIfErrorMessageIsSet()
        {
            var controller = new HomeController();
            
            controller.Calculate(-6);

            Assert.IsNotNull(controller.TempData.ContainsKey("Error"));

        }

    }
}
