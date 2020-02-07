using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Web;
using EmartApplication.Model;

namespace EmartApplication.Controllers
{
    //  SellerInterface se = new SellerBo();
    // private readonly SellerBo seb;
    //public SellerController(SellerBo se)
    //{
    //  se = seb;
    //}


    public class Sellercontroller : Controller
    {
        private readonly SellerBo employeeRepository;
        public SellerController(SellerInterface emrepository)//dependency injected object
        {
            employeeRepository = emrepository;
        }
        public ContentResult Search(int? id)
        {
            int Id = (int)((id == null) ? 1 : id);

            Seller emp = employeeRepository.GetEmployee(Id);
            if (emp != null)
            {
                return Content(emp.Id + "\n" + emp.Name + "\n" + emp.Email + "\n " + emp.Dept);
            }
            else
                return Content("Employee does not exist");
        }
        public IActionResult Index()
        {
            List<Employee> elist = employeeRepository.Display();
            return View(elist);
        }

        public ViewResult AboutEmployee()
        {
            Employee emp = employeeRepository.GetEmployee(2);
            //ViewBag.projectName = "BlackPanter";
            EmployeeProjectViewModel ep = new EmployeeProjectViewModel();
            ep.employee = emp;
            ep.projectname = "BlackPanter";
            return View(ep);
        }
        public IActionResult GetAllEmployees()
        {
            List<Employee> elist = employeeRepository.Display().Where(e => e.Dept == "cse").ToList();
            //absolute path to refer a view
            return View("Index", elist);
        }
    }
}

