using EPiServer.Web.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EpSMS9.Models.Pages;

namespace EpSMS9.Controllers
{
    public class StartPageController : PageController<StartPage>
    {
        // GET: StartPage
        public ActionResult Index(StartPage currentPage)
        {
            return View(currentPage);
        }
    }
}