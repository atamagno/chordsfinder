using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ChordsFinder.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Song()
        {
            return View();
        }

        public ActionResult MySongs()
        {
            return View();
        }

        public ActionResult UploadSong()
        {
            return View();
        }

        public ActionResult SearchResults()
        {
            return View();
        }
    }
}