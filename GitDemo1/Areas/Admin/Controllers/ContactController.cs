using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GitDemo1.Areas.Admin.Controllers
{
    public class ContactController : Controller
    {
        // GET: Admin/Contact
        public ActionResult Index()
        {
            return View();
        }
    }
}