using scrcProiect.DatabaseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace scrcProiect.Controllers
{
    public class CarController : Controller
    {
        

        // GET: Car
        public ActionResult Index()
        {
            List<Car> result = new List<Car>();

            using (DatabaseContext context = new DatabaseContext())
            {

           
                result =context.Cars.ToList();
            }

                return View(result);
        }

        [HttpGet]
        public ActionResult Create()
        {


            return View();
  
        }

        [HttpPost]
        public ActionResult Create(Car car)
        {
            if (ModelState.IsValid)
            {
                using (DatabaseContext context = new DatabaseContext())
                {
                    car.Id = Guid.NewGuid();
                    context.Cars.Add(car);
                    context.SaveChanges();
                    return RedirectToAction("Index");

                }
            }
           
                return View();

        }
    }
}