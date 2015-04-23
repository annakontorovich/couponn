using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CouponSystem1
{
    public enum category { Clothing, Food, Sport, Pleasure, Consumerism };

    public class Category
    {
        public category _category { get; set; }
        public List<PrivateUser> users { get; set; }
        public List<Business> businesses { get; set; }
    }
}
