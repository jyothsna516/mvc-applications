using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeDetails.model
{
    interface IemployeeRepositry
    {
        Employee GetEmployee(int id);
    }
}
