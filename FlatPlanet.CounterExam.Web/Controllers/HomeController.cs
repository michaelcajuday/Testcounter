using FlatPlanet.CounterExam.Business.Interfaces;
using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FlatPlanet.CounterExam.Web.Controllers
{
    public class HomeController : Controller
    {
        [Dependency]
        public ICounterTableService CounterTableService { get; set; }

        private string message = "";
        private bool isError = false;

        public ActionResult Index()
        {
            ViewBag.CurrentCounter = CounterTableService.Get(out message, out isError);
            return View();
        }

        [HttpPost]
        public ActionResult Index(CountAction action)
        {
            if(action == CountAction.Increment)
            {
                CounterTableService.Increment(out message, out isError);
                if (isError) throw new Exception(message);
            }
            else
            {
                CounterTableService.Reset(out message, out isError);
            }

            return RedirectToAction("index");
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Error(string e)
        { 
            return View("error");
        }
    }

    public enum CountAction
    {
        Increment =1,
        Reset
    }
}