

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Web;
using EmployeeManage.Model;
using Microsoft.AspNetCore.Authorization;
namespace EmployeeManage.Controllers
{
    public class EmployeeController : Controller
    {
        //  IEmployeeRepository employeeRepository = new EmployeeRepository();


        //IEmployee employeeRepository = new EmployeeRepository(); 
        private readonly IEmployeeRepository employeeRepository;
        //dependency injected object
        public EmployeeController(IEmployeeRepository emRepository)
        {
            employeeRepository = emRepository;
        }
        public IActionResult Search(int? id)
        {
            int ID = (int)((id == null) ? 1 : id);
            Employee emp = employeeRepository.GetEmployee(ID);
            //if (emp != null)
            //{
            //    return Content(emp.Id + "\n" + emp.Name + "\n" + emp.Email + "\n" + emp.Dept);
            //}
            //return Content("Employee does not exist");



            //ViewData["id"] = emp.Id;
            //ViewData["name"] = emp.Name;
            //ViewData["email"] = emp.Email;
            //ViewData["dept"] = emp.Dept;

            //ViewBag.id = emp.Id;
            //ViewBag.name = emp.Name;
            //ViewBag.email = emp.Email;
            //ViewBag.dept = emp.Dept;

            //ViewData["employee"] = emp;
            //ViewBag.employee = emp;
            return View(emp);
        }
        public IActionResult Index()
        {
            List<Employee> elist = employeeRepository.DisplayDetails();
            return View(elist);
        }
        public ViewResult AboutEmployee()
        {
            Employee emp = employeeRepository.GetEmployee(1);
            //ViewBag.projectName = "BookHive";
            EmployeeProjectViewModel ep = new EmployeeProjectViewModel();
            ep.employee = emp;
            ep.projectName = "BookHive";
            return View(ep);
        }
        public IActionResult GetAllEmployees()
        {
            List<Employee> elist = (employeeRepository.DisplayDetails()).Where(e => e.Dept == Dept.Insurance).ToList();
            //Absolute path to refer a view
            //return View("~/Views/Employee/Index.cshtml", elist);
            //relative path to refer a view
            return View("Index", elist);
        }
        [HttpGet]
        public IActionResult Create()
        {
            //Employee emp = employeeRepository.GetEmployee(1);
            //return View(emp);
            return View();
        }
        [HttpPost]
        public IActionResult Create(Employee emp)
        {
            if (ModelState.IsValid)
            {
                employeeRepository.AddEmployee(emp);
                return RedirectToAction("Index");
            }
            //else
            //    return View("Fail");
            return View();
        }
        public IActionResult Success()
        {
            return View();
        }
        public IActionResult List()
        {
            List<Employee> elist = employeeRepository.DisplayDetails();
            return View(elist);
        }
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }
        public IActionResult Fail()
        {
            return View();
        }
        [HttpPost]

        public IActionResult Register(Employee employee)
        {
            bool res = employeeRepository.AddEmployee(employee);
            return RedirectToAction("Index");
        }
        public bool IsExist(string email)
        {
            var result = (employeeRepository.DisplayDetails()).Find(r => r.Email == email);
            if (result == null)
                return true;
            else
                return false;
        }
        [AcceptVerbs("Get", "Post")]
       
        public JsonResult IsEmailExist(string email)
        {
            return IsExist(email) ? Json(true) : Json("email exist");
        }
        public IActionResult _mypartial()
        {
            return View();
        }


    }
}
