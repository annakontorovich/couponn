using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CouponSystem1
{
    public abstract class User
    {
        public string userName { get; set; }
        public long phoneNumber { get; set; }
        public string password { get; set; }
        public string lastName { get; set; }
        public string firstName { get; set; }
        public string email { get; set; }
        public int age { get; set; }

        public List<CouponInSocialNetwork> socialNetworkCoupons { get; set; }

    }
}
