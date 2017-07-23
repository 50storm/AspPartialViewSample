using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcClient.Controllers
{
  public class LibraryController : Controller
  {
    public ActionResult Jquery()
    {
      return View();
    }

    public ActionResult Jqueryui()
    {
      return View();
    }

    public ActionResult Jquerymobile()
    {
      return View();
    }
    // GET: Library
    public ActionResult Index()
    {
      return View();
    }
  }
}