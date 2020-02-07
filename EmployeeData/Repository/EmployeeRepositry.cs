using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EmployeeData.Models;
namespace EmployeeData.Repository
{
    public class EmployeeRepositry
    {

        public static List<Employee> list = new List<Employee>() { new Employee() { Name = "jyo", EmployeeId = "123", Password = "jyo123" }
        };

        public EmployeeRepositry()
        {
        }
        public void Add(Employee em)
        {
            list.Add(em);// add user data in list
        }
        public Employee Validate(string empid, string pwd)
        {
            foreach (var em in list)
            {
                if (em.EmployeeId == empid && em.Password == pwd)
                {
                    return em;
                }

            }
            return null;
        }
    }
}

