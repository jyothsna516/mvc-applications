using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Web;
using WebApplication6.model;
using WebApplication6.Model;

namespace WebApplication6.Controllers


{
    public class EmployController : Controller
    {
        private readonly Interface empr;
        //dependancy injected object
        public EmployController(Interface empr1)
        {
            empr = empr1;
        }
        //Interface empr = new Employr();
        public ActionResult Search(int? id)
        {
            int ID = (int)((id == null) ? 1 : id);
            Employ emp1 = empr.GetEmploy(ID);
            if (emp1 != null)
            {
                return Content(emp1.Id + "\n" + emp1.Name + "\n" + emp1.Email + "\n" + emp1.dept);
            }
            return Content("emp does not exist");
        }
        public string Index()
        {
            return "hiiii";
        }
        //public string ContactUs()
        //{
        //    return "hiiii";
        //}
        //public JsonResult AboutUs()
        //{
        //    return JsonResult("{(id:1;name:")
        //}
        //public ViewResult AboutUs()
        //{
        //    return View();
        //}
    }
}