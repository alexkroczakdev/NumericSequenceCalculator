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
        ICalculateSequence Sequence;
        Dictionary<string, ICalculateSequence> SequenceList;

        public ActionResult Index()
        {
            SequenceList = new Dictionary<string, ICalculateSequence>();
            Session["SequenceList"] = SequenceList;
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

            CheckIfAlreadyExist(sequenceChoice);

            TempData["Sequence"] = SequenceList[sequenceChoice].Calculate((int)sequenceNumber);

            return RedirectToAction("ViewSequence");
        }

        public ActionResult ViewSequence()
        {
            if (TempData["Sequence"] != null)
            {
                ViewBag.Sequence = TempData["Sequence"].ToString();
            }
            return View("ViewSequence");
        }

        private void CheckIfAlreadyExist(string sequenceChoice)
        {
            SequenceList = Session["SequenceList"] as Dictionary<string, ICalculateSequence>;

            if (!SequenceList.ContainsKey(sequenceChoice))
            {
                Sequence = FactorySequence.GetSequence(sequenceChoice);
                SequenceList.Add(sequenceChoice, Sequence);
                Session["SequenceList"] = SequenceList;
            }
        }

    }
}