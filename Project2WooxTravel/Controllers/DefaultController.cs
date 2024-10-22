﻿using Project2WooxTravel.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project2WooxTravel.Controllers
{
    public class DefaultController : Controller
    {
        TravelContext context = new TravelContext();    
        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult PartialHead()
        {
            return PartialView();
        }

        public ActionResult PartialScript()
        {
            return PartialView();
        }

        public ActionResult PartialNavbar()
        {
            return PartialView();
        }

        public ActionResult PartialBanner()
        {
            return PartialView();
        }

        public ActionResult PartialCountry()
        {
            var values = context.Destinations.ToList();
            return PartialView(values);
        }

        public ActionResult PartialFooter()
        {
            return PartialView();
        }
    }
}