using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CouponSystem1
{
    public class CouponInCatalog
    {
        public int id { get; set; }
        public string address { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public double originalPrice { get; set; }
        public double priceAfterDiscount { get; set; }
        public string city { get; set; }
        public int totalRank { get; set; }
        public DateTime lastDateToUse { get; set; }
        public BusinessOwner suggestedBy { get; set; }
        public SystemManager addedBy { get; set; }

    }
}
