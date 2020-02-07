using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Web;
//using EmployeeDetails.Controllers;

namespace EmployeeDetails.controllers

{
    public class EmployeeController
    {

        IemployeeRepositry empr = new IemployeeRepositry();
        public string Search()
        {
            Employee emp1=empr. GetEmployee(int id);
            Employee emp1 = empr.GetEmploy(1);
            return emp1.Id + "\n" + emp1.Name + "\n" + emp1.Email + "\n" + emp1.dept;
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

