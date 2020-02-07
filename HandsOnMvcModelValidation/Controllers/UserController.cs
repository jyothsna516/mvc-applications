using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HandsOnMvcModelValidation.Models;
using HandsOnMvcModelValidation.Repositories;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace HandsOnMvcModelValidation.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Create()//GET REQUEST
        {
            ViewBag.Country = new SelectList(new string[] { "select country ","India", "china", "USA" });
            return View();
        }
        [HttpPost]
        public IActionResult Create(User item)//POST REQUEST
        {
            UserRepository repository = new UserRepository();
            repository.Add(item);
            return RedirectToAction("Login");
        }
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(string uname,string pwd)
        {
            UserRepository repository = new UserRepository();
            User user = repository.Validate(uname, pwd);
            if (user != null)
            {
                return RedirectToAction("Details",user);
            }
            else
            {
                ViewData["err"] = "Invalid Credentials";
                return View();
            }
        }
        /* public IActionResult Details(User item)
         {
             return View(item);
         }*/
        public IActionResult Details([Bind(include:"Name")]User item)
        {
            return View(item);
        }
        public IActionResult Greet(int id)
        {
            return View();
        }
    }
}