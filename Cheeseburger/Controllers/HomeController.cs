using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KProteinService;
using Cheeseburger.Domain;
using Cheeseburger.Service;

namespace Cheeseburger.Controllers
{
    public class HomeController : Controller
    {
        private ProteinService _ps;

        public HomeController(ProteinService ps)
        {
            _ps = ps;
        }

        public ActionResult Index()
        {
            //ProteinService ps = new ProteinService();
            var name = _ps.getProtein();
            var cals = _ps.getCalories();

            ObjectService svc = new ObjectService();

            List<TargetField> fields = new List<TargetField>();
            fields.Add(new TargetField { Name = "field_1" });
            fields.Add(new TargetField { Name = "field_2" });

            TargetClass targetClass = new TargetClass
            {
                Name = "MyClass",
                Fields = fields
            };

            svc.AddClass(targetClass);



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