﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _272JABSProject.Controllers
{
    public class FitnessController : Controller
    {
        // GET: Fitness
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ActivityInput()
        {
            return View();
        }

        public ActionResult FoodInput()
        {
            return View();
        }
    }
}