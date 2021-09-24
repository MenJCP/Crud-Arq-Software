using CS.WebApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CS.WebApplication.Controllers
{
    public class CalculatorController : Controller
    {
        // GET: Calculator
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(OperationModel model)
        {
            decimal Result = 0;

            if(model.OperationSymbol == "+")
            {
                Result = model.Param1 + model.Param2;
            }
            else if(model.OperationSymbol == "-")
            {
                Result = model.Param1 - model.Param2;
            }
            else if (model.OperationSymbol == "*")
            {
                Result = model.Param1 * model.Param2;
            }
            else if (model.OperationSymbol == "/")
            {
                Result = model.Param1 / model.Param2;
            }
            else
            {
                Result = -1;
            }

            model.Result = $"El resultado es {model.Param1} {model.OperationSymbol} {model.Param2} = {Result}";

                return View(model);
        }


    }
}