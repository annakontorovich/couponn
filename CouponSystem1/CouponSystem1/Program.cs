using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace CouponSystem1
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new Context())
            {
                // Create and save a new Blog 
                Console.Write("Enter username: ");
                var name = Console.ReadLine();

                var user = new PrivateUser { firstName = name };
                db.PrivateUsers.Add(user);
                db.SaveChanges();

                // Display all Blogs from the database 
                var query = from b in db.PrivateUsers
                            orderby b.firstName
                            select b;

                Console.WriteLine("All private users in the database:");
                foreach (var item in query)
                {
                    Console.WriteLine(item.firstName);
                }

                //Console.WriteLine("Press any key to exit...");
                Console.ReadKey();
            } 
        }
    }

}
