using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CouponSystem1
{
    public class PrivateUser : User
    {
        public string location { get; set; }
        public List<Category> categories { get; set; }
        public List<Coupon> coupons { get; set; }
    }
}
