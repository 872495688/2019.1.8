using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ContosoUniversity2.DAL;
using ContosoUniversity2.ViewModels;
using ContosoUniversity2.comm;

namespace ContosoUniversity2.Controllers
{
    [AllowAnonymous]
    public class HomeController : Controller
    {
        private SchoolContext db = new SchoolContext();
        public ActionResult Index()
        {
            var data = WeatherHelper.GetWeatherByCityName("柳州");
            return View(data);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page";
            return View();
            //IQueryable<EnrollmentDateGroup> data = from student in db.Students
            //                                       group student by student.EnrollmentDate into dateGroup
            //                                       select new EnrollmentDateGroup()
            //                                       {
            //                                           EnrollmentDate = dateGroup.Key,
            //                                           StudentCount = dateGroup.Count()
            //                                       };
            //return View(data.ToList());
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}