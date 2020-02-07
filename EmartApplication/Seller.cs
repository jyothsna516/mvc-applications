using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmartApplication
{
    public class Seller
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phno { get; set; }
        public string Cname { get; set; }
        public string Gstin { get; set; }
        public string Email { get; set; }

       // int Id;
        public Seller(int id, string name, string phno, string email, string cname, string gstin)
        {
            this.Id = id;
            this.Name = name;
            this.Phno = phno;
            this.Cname = cname;
            this.Gstin = gstin;
            this.Email = email;
        }
    }
}

        


