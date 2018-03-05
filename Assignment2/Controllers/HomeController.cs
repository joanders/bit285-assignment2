using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;
using Assignment2.Models;
//BIT 285
//Assignment 2
//Joan Dawson
namespace Assignment2.Controllers
{

    public class HomeController : Controller
    {
        VisitorLogContext vl = new VisitorLogContext();

        public ActionResult Index()
        {
            return View("Index", vl.Activities);
        }
    }

}
