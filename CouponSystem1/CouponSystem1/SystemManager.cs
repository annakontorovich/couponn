using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CouponSystem1
{
    public class SystemManager : User
    {
        public List<CouponInCatalog> couponsAddedBy { get; set; }

    }
}
