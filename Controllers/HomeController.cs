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
            Organisations companies1 = new Organisations("Food and Agriculture Org.", "0129876543", "2022/08/18", 55000.00, true);
            Individuals volunteer1 = new Individuals("Tshepo Mononyane", "0762444724", "2022/08/18", 78000.00, true);
            Organisations companies2 = new Organisations("Hlomishlangusakho Holding","0124595123","2022 - 08 - 20" ,155000.00 ,false);
            Individuals volunteer2 = new Individuals("Neliswa Simelane", "0725649872", "2022/08/20", 5000.00, true);
            Individuals volunteer3 = new Individuals("Keegan Bosmen", "0725649872", "2022/08/20", 7800.00, false);
            Individuals volunteer4 = new Individuals("Atlehang Lekau", "0834183281", "2022/08/21", 91000.00, false);
            Organisations companies3 = new Organisations("AL Tradings", "0120495123", "2022 - 08 - 20", 1105000.00, true);
            Individuals volunteer5 = new Individuals("Zandile Maseko", "0604595123", "2022/08/21", 100000.00, true);
            members.Add(companies1);
            members.Add(volunteer1);
            members.Add(volunteer2);
            members.Add(volunteer3);
            members.Add(volunteer4);
            members.Add(companies2);
            members.Add(companies3);
            members.Add(volunteer5);
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