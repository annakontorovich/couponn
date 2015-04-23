using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CouponSystem1
{
    public class Coupon : CouponInCatalog
    {
        public string serialKey { get; set; }
        public bool used { get; set; }
        public DateTime orderedDate { get; set; }
        public int rank { get; set; }
        public PrivateUser user { get; set; }
    }
}
