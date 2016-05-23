using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Week18_MultipleModelDemo_05122016.Models;

namespace Week18_MultipleModelDemo_05122016.Controllers
{
    public class HomeController : Controller
    {
        Repository _respository = new Repository();

        public ActionResult ViewDataDemo()
        {
            ViewData["Courses"] = _respository.GetCourses();
            ViewData["Students"] = _respository.GetStudents();
            ViewData["Faculties"] = _respository.GetFaculties();
            return View();
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}