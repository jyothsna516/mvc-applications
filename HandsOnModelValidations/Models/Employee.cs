using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
namespace HandsOnModelValidations.Models
{
    public class Employee
    {
        [Required(ErrorMessage = "pls enter id")]
        [DisplayName("Employee Id")]
        public int ID { get; set; }
        [Required(ErrorMessage = "pls enter Name:")]
        [StringLength(maximumLength: 20, MinimumLength = 4, ErrorMessage = "Name should be ")]
        public string Name { get; set; }
        [EmailAddress(ErrorMessage = "Invalid Email Id")]
        public string Email { get; set; }
        [RegularExpression(@"[6-9]\d{9}", ErrorMessage = "Invalid mobile no")]
        public string Mobile { get; set; }
        [Required(ErrorMessage = "username is required")]
        public string Uname { get; set; }
        [Required(ErrorMessage = "password is required")]
        [RegularExpression(@"[a-z0-9]{6,8}", ErrorMessage = "pls try new password")]
        public string Pwd { get; set; }
        [Compare("Pwd", ErrorMessage = "password mismatch")]
        public string Cpwd { get; set; }

    }
}
