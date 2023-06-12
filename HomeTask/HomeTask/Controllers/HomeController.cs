using HomeTask.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace HomeTask.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.CompanyName = "Nascenia";
            return View();
        }

        public ActionResult Services()
        {
            ServicesModel s1 = new ServicesModel()
            {
                Title = "Web Development",
                Description = "Ruby on Rails,php,.Net,Nodejs"

            };

            ServicesModel s2 = new ServicesModel()
            {

                Title = "UI/UX Design",
                Description = "Requirment Generation,Wireframing,Design for web and mobile"

            };
            ServicesModel[] services = new ServicesModel[] { s1, s2 };

            return View(services);
        }

        public ActionResult Terms_Members()
        {
            MembersModel[] members = new MembersModel[]
            {
                new MembersModel("Md. Shahadat Hossain","html" ),
                new MembersModel("Aditi Debnath","php" ),
                new MembersModel("Farhana Tasneem",".Net" )
            };
            return View(members);
        }
        public ActionResult Contact() => View();
    }
}