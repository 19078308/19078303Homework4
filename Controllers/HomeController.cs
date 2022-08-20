using _19078303Homework4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _19078303Homework4.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Home()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "What we doing and what we want to achieve.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Donate()
        {
            List<Individuals> donors = GetVolunteer();
            return View(donors);
        }

        public ActionResult Members()
        {
            List<Members> members = new List<Members>();
            Organisations companies1 = new Organisations("Food and Agriculture Org.", 0129876543, "2022/08/18", 55000.00, true);
            Individuals volunteer1 = new Individuals("Tshepo Mononyane", 0762444724, "2022/08/18", 78000.00, true);
            members.Add(companies1);
            members.Add(volunteer1);
            return View(members);
        }

        private List<Individuals> GetVolunteer()
        {
            List<Individuals> volunteers = new List<Individuals>();
            return volunteers;
        }
        private List<Organisations> GetOrganisation()
        {
            List<Organisations> companies = new List<Organisations>();
            return companies;
        }


    }
}