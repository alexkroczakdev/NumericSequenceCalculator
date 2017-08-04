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
            if(TempData["Error"] != null)
            {
                ViewBag.Error = TempData["Error"].ToString();
            }           
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
        public ActionResult Calculate(double? sequenceNumber, string sequenceChoice)
        {   
            Validator = new ValidateNumber();
            if (Validator.ValidateInputNumber(sequenceNumber) == false)
            {
                TempData["Error"] = "The number is invalid";
                return RedirectToAction("Index");
            }

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
                case "c": Calculator = new CSequence();
                    break;
                case "e": Calculator = new ESequence();
                    break;
                case "z": Calculator = new ZSequence();
                    break;
                case "fibonacci": Calculator = new FibonacciSequence();
                    break;
                default: Calculator = new Sequence();
                    break;
            }
        }
        




    }
}