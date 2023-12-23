using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace TestWeb.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ((System.Web.HttpContext)HttpContext).Session["PageName"] = "Updated from CORE App";            
            return View();
        }       
    }
}