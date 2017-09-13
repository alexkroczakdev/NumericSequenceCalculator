using System;
using System.Collections.Generic;
using System.Web.Mvc;
using TaskCalculator.BuisnessLayer;
using TaskCalculator.Interfaces;

namespace TaskCalculator.Controllers
{
    public class HomeController : Controller
    {
        IValidateNumber Validator;
        ICalculateSequence Calculator;

        public ActionResult Index()
        {
           return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }
        public ActionResult Instruction()
        {
            return View();
        }

        [HandleError(ExceptionType = typeof(ArgumentException), View ="InvalidInputError")]
        public ActionResult Calculate(UInt32 sequenceNumber, string sequenceChoice)
        {

            Validator = new ValidateNumber();
            if (!Validator.ValidateInputNumber(sequenceNumber))
                return View("InvalidInputError");
            

            SetCalculator(sequenceChoice);
            TempData["Sequence"] = Calculator.Calculate((int)sequenceNumber);

            return RedirectToAction("Sequence");
        }

        public ActionResult Sequence()
        {
            if (TempData["Sequence"] != null)
            {
                ViewBag.Sequence = TempData["Sequence"].ToString();
            }
            return View("Sequence");
        }

        private void SetCalculator(string sequenceChoice)
        {            
            switch (sequenceChoice)
            {
                case "odd": Calculator = new OddSequence();
                    break;
                case "even": Calculator = new EvenSequence();
                    break;
                case "zce": Calculator = new ZCESequence();
                    break;
                case "fibonacci": Calculator = new FibonacciSequence();
                    break;
                default: Calculator = new Sequence();
                    break;
            }
        }
        




    }
}