using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace HandsOnMvcModelValidation.Models
{
    public class User
    {
        [Required(ErrorMessage = "pls enter id")]
        public int ID { get; set; }
        [Required(ErrorMessage = "pls enter Name:")]
        [StringLength(maximumLength: 20, MinimumLength = 4, ErrorMessage = "Name should be ")]
        public string Name { get; set; }
        
        public string Email{ get; set; }
        [Required(ErrorMessage = "pls SELECT THE DOB")]
        public DateTime Dob { get; set; }
        [RegularExpression(@"[6-9]\d{9}", ErrorMessage = "Invalid phone no")]
        public string Phno { get; set; }
        [Required(ErrorMessage ="PLS SELECT THE COUNTRY")]
        public string Country { get; set; }
        [Required(ErrorMessage ="pls enter the valid username")]
        [StringLength(maximumLength: 20, MinimumLength = 4, ErrorMessage = "userName should be ")]
        public string Uname { get; set; }
        [Required(ErrorMessage ="pls enter the  password ")]
        [RegularExpression(@"[a-z0-9]{5,8}", ErrorMessage = "pls try new password")]
        public string Pwd { get; set; }
       
    }
}
