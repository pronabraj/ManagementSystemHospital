using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;
using Hospital.Models;

namespace Hospital.Controllers
{
    public class HomeController : Controller
    {
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
        Database1Entities DB = new Database1Entities();
        public ActionResult Action()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Action(login S)
        {
            DB.logins.Add(S);
            var st = DB.SaveChanges();
            if (st > 0)
            { }
            else 
            {
            }
            ModelState.Clear();
            return View();
        }

        public ActionResult doctor()
        {
            return View();
        }
        [HttpPost]
        public ActionResult doctor(Doctor_Info a)
        {
            Database1Entities1 D = new Database1Entities1();
            D.Doctor_Infoes.Add(a);
            var st = D.SaveChanges();
            if (st > 0)
            { }
            else
            {
            }
            ModelState.Clear();
            
            return View();
        }
        public ActionResult Patient()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Patient(Patient_Info a)
        {
            Database1Entities2 D = new Database1Entities2();
            D.Patient_Infoes.Add(a);
            var st = D.SaveChanges();
            if (st > 0)
            { }
            else
            {
            }
            ModelState.Clear();
            

            return View();
        }

     

        public ActionResult doctorList() 
        {
          Database1Entities1 D = new Database1Entities1();
          return View(D.Doctor_Infoes.ToList());
        }

        public ActionResult PatientList()
        {
            Database1Entities2 D = new Database1Entities2();
            return View(D.Patient_Infoes.ToList());
        }

        public ActionResult EmployeePhotoAdd()
        {
            return View();
        }
        [HttpPost]
        public ActionResult EmployeePhotoAdd(Class1 pic)
        {

            foreach (var file in pic.Files)
            {
                if (file.ContentLength > 0)
                {

                    var fileName = Path.GetFileName(file.FileName);
                    var path = Path.Combine(Server.MapPath("~/Content/images"), fileName);
                    file.SaveAs(path);
                }
            }

            return RedirectToAction("Index");
        }

        public ActionResult Prescribction()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Prescribction(Detail a)
        {
            Database1Entities3 D = new Database1Entities3();
            D.Details.Add(a);
            var st = D.SaveChanges();
            if (st > 0)
            { }
            else
            {
            }
            ModelState.Clear();


            return View();


        }
        public ActionResult list()
        {
            Database1Entities3 D = new Database1Entities3();
            return View(D.Details.ToList());
        }

    }

  
}