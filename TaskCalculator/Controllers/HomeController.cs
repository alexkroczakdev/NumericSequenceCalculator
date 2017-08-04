using System.Web.Mvc;
using TaskCalculator.BuisnessLayer;
using TaskCalculator.Interfaces;

namespace TaskCalculator.Controllers
{
    public class HomeController : Controller
    {
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
            IValidateNumber validator = new ValidateNumber();
            var isValidated = validator.ValidateInputNumber(sequenceNumber);
            if (isValidated == false)
            {
                TempData["Error"] = "The number is invalid";
                return RedirectToAction("Index");
            }

            var calculator = SetCalculator(sequenceChoice);
            var seqnumber = (int)sequenceNumber;
            TempData["Sequence"] = calculator.Calculate(seqnumber);

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

        private ICalculateSequence SetCalculator(string sequenceChoice)
        {
            ICalculateSequence calculator;
            switch (sequenceChoice)
            {
                case "odd": calculator = new OddSequence();break;
                case "even": calculator = new EvenSequence(); break;
                case "c": calculator = new CSequence(); break;
                case "e": calculator = new ESequence(); break;
                case "z": calculator = new ZSequence(); break;
                case "fibonacci": calculator = new FibonacciSequence(); break;

                default: calculator = new Sequence();break;
            }
            
            return calculator;
        }
        




    }
}