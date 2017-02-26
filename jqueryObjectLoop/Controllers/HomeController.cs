using jqueryObjectLoop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace jqueryObjectLoop.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {


            return View();
        }
        [HttpGet]
        public ActionResult getBroker()
        {
            var user1 = new UsersViewModel(1, "Anish");
            var user2 = new UsersViewModel(2, "Sobit");
            var user3 = new UsersViewModel(3, "Ryan");
            var user4 = new UsersViewModel(4, "David");

            var company1 = new CompanyViewModel(5, "GrowByData");
            company1.Users = new List<UsersViewModel>();
            company1.Users.Add(user1);
            company1.Users.Add(user2);

            var company2 = new CompanyViewModel(6, "StatusNotQuo");
            company2.Users = new List<UsersViewModel>();
            company2.Users.Add(user3);
            company2.Users.Add(user4);

            var broker = new BrokerViewModel(7, "Broker");
            broker.Companies = new List<CompanyViewModel>();
            broker.Companies.Add(company1);
            broker.Companies.Add(company2);

            return Json(broker, JsonRequestBehavior.AllowGet);
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