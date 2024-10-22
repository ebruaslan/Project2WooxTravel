using Project2WooxTravel.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project2WooxTravel.Areas.Admin.Controllers
{
    

    public class MessageController : Controller
    {
        TravelContext context = new TravelContext();    
        // GET: Admin/Message
        public ActionResult Inbox()
        {
            var a = Session["x"];
            var email = context.Admins.Where(x=>x.Username == a).Select(x=>x.Email).FirstOrDefault();
            var values = context.Messages.Where(x => x.ReceiverMail == email).ToList();


            return View(values);
        }
    }
}