using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeDetails.model
{
    public class EmployeeRepositry:IemployeeRepositry
    {
        private List<Employee> emp;
        public EmployeeRepositry()
        {
            emp = new List<Employ>() { new Employ ( 1, "dsfk","dsfgdsg@gmail.com","csf"),
            new EmployeeDetails ( 2, "dsfk","dsfgdsg@gmail.com","csf"),
            new Employee ( 3, "dsfk","dsfgdsg@gmail.com","csf")};
        }
        public Employee GetEmploy(int id)
        {
            Employ e = emp.FirstOrDefault(e => e.Id == id);
            //foreach(Employ X in emp)
            //{
            //    if (X.Id == id) return X;

            return e;
        }
    }

}
