using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmartApplication.Model
{
  public  interface SellerInterface
    {
        Seller GetSeller(string id);
        List<Seller> DisplayDetails();
    }
}
