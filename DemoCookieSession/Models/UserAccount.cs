using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DemoCookieSession.Models
{
    public class UserAccount
    {
        [Key]
        public string UserName { get; set; }
        [DataType("password")]
        public string Password{ get; set; }

        public string Email { get; set; }
        public string Role { get; set; }
        public bool status { get; set; }



    }
}
