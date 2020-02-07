using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace EmployeeDManagement.Models
{
    public enum departement
    {
            it,accounts,insurance,healthcare
    }
    public class Employee
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Email { get; set; }
        public departement Dept { get; set;}

    }
}
