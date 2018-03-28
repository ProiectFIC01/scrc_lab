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

        //create car
        [HttpGet]
        public ActionResult Create()
        {


            return View();
  
        }

        //save created car
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

        //edit car
        [HttpGet]
        public ActionResult Edit(Guid id)
        {
            Car result = null;
            using (var databaseContext = new DatabaseContext())
            {
                result = databaseContext.Cars.FirstOrDefault(s => s.Id == id); //find car to edit


            }
                return View(result);

        }

        //save edited item
        [HttpPost]
        public ActionResult Edit(Car car)
        {
            if (ModelState.IsValid)
            {
                using (DatabaseContext context = new DatabaseContext())
                {
                    Car existingCar = context.Cars.FirstOrDefault(s => s.Id == car.Id);
                    existingCar.LicensePlate = car.LicensePlate;
                    existingCar.Model = car.Model;
                    existingCar.Model = car.Model;
                    existingCar.Color = car.Color;
                    existingCar.Year = car.Year;

                    context.SaveChanges();
                    return RedirectToAction("Index");

                }
            }

            return View();
        }



        //delete car view
        [HttpGet]
        public ActionResult Delete(Guid id)
        {
            Car result = null;
            using (var databaseContext = new DatabaseContext())
            {
                result = databaseContext.Cars.FirstOrDefault(s => s.Id == id); //find car to delete

            }
            return View(result);

        }


        //delete
        [HttpPost]
        public ActionResult Delete(Car car)
        {
            if (ModelState.IsValid)
            {
                using (DatabaseContext context = new DatabaseContext())
                {
                    Car result = context.Cars.FirstOrDefault(s => s.Id == car.Id);

                    context.Cars.Remove(result);
                   
                    context.SaveChanges();
                    return RedirectToAction("Delete");

                }
            }

            return View();
        }



    }
}