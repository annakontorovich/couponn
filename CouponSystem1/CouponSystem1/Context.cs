using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CouponSystem1
{
    public class Context : DbContext 
    {
        public DbSet<Business> Businesss { get; set; }
        public DbSet<BusinessOwner> BusinessOwners { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Coupon> Coupons { get; set; }
        public DbSet<CouponInCatalog> CouponInCatalogs { get; set; }
        public DbSet<CouponInSocialNetwork> CouponInSocialNetwork { get; set; }
        public DbSet<PrivateUser> PrivateUsers { get; set; }
        public DbSet<SystemManager> SystemManagers { get; set; }
        public DbSet<User> Users { get; set; } 





    }
}
