using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.SignalR;
using WebAPI.Hubs;

namespace WebAPI.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";
            var context = GlobalHost.ConnectionManager.GetHubContext<Testing>();
            context.Clients.All.Send("Hello Everyone");
            return View();
        }
    }
}
