using scrcProiect.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace scrcProiect.Controllers
{
    public class CustomController : Controller
    {
        // GET: Custom
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ShowCustomModel()
        {
            CustomModel customModel = new CustomModel();
            customModel.Name = "Alexandru Imosanu";
            customModel.Age = 21;
            return View(customModel);
        }

        [HttpGet]
        public ActionResult CreateCustomModel()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateCustomModel(CustomModel custom)
        {
            return View();
        }
    }
}