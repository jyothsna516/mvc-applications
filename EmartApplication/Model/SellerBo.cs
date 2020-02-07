using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmartApplication.Model
{
    public class SellerBo:SellerInterface
    {
        private List<Seller> sell;
        public SellerBo()
        {
            sell = new List<Seller>() { new Seller("123", "dsfk", "42135426517", "dsfgdsg@gmail.com", "csf", "6172671") };
        }
        public Seller GetSeller(string id)
        {
            Seller e = sell.FirstOrDefault(e => e.Id == id);
            //foreach(Employ X in emp)
            //{
            //    if (X.Id == id) return X;

            return e;
        }
        public List<Seller> DisplayDetails()
        {
            return sell;
        }
    }
}
