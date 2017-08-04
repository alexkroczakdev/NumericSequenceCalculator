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
            ICalculateSequence calculator = new Sequence();
                        
            IValidateNumber validator = new ValidateNumber();
            var isValidated = validator.ValidateInputNumber(sequenceNumber);
            if (isValidated == false)
            {
                TempData["Error"] = "The number is invalid";
                return RedirectToAction("Index");
            }

            var seqnumber = (int)sequenceNumber;

            return View("Index");
        }
        




    }
}