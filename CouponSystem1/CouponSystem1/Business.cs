using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CouponSystem1
{
    public class Business
    {
        public BusinessOwner bussinessOwner { get; set; }
        public string brandName { get; set; }
        public string address { get; set; }
        public string city { get; set; }
        public string description { get; set; }
        public int rank { get; set; }
    }
}
