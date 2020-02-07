using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EmployeeData.Models;
using EmployeeData.Repository;
using Microsoft.AspNetCore.Mvc.Rendering;
namespace EmployeeData.Controllers
{
    public class EmployeeController:Controller
    {

        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Create()//GET REQUEST
        {
            ViewBag.Desigination = new SelectList(new string[] { "PAT","senior associate","PA" });
            ViewBag.ProjectName = new SelectList(new string[] { "emart", "online book shopping", "webapp" });
            return View();
        }
        [HttpPost]
        public IActionResult Create(Employee em)//POST REQUEST
        {
            EmployeeRepositry repository = new EmployeeRepositry();
            repository.Add(em);
            return RedirectToAction("Login");
        }
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(string emailid, string pwd)
        {
            EmployeeRepositry repository = new EmployeeRepositry();
            Employee emp = repository.Validate(emailid, pwd);
            if (emp != null)
            {
                return RedirectToAction("Details", emp);
            }
            else
            {
                ViewData["err"] = "Invalid Credentials";
                return View();
            }
        }
        public IActionResult Details(Employee em)
        {
            return View(em);
        }
        public IActionResult Greet(int id)
        {
            return View();
        }
       
    }
}
  
