using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Employee.model
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }

        public Employee(int Id, string Name, string Email, int Age)
        {
            this.Id = Id;
            this.Name = Name;
            this.Email = Email;
            this.Age = Age;

        }
    }
}
