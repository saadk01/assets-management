using CPRG254.Assets.Data;
using CPRG254.Assets.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPRG254.Assets.Repositories
{
    public class VendorManager : Vendor
    {
        public static IEnumerable<Vendor> GetAll()
        {
            // The following line of code is to be un-commented if there's no Entity Framework
            // (The EF usage then should naturally be commented out).
            // var vendors = LoadTestData();

            var context = new AssetContext();
            var vendors = context.Vendors.ToList();

            return vendors;
        }

        // Adds vendor to the system
        public static void Add(Vendor ven)
        {
            var context = new AssetContext();
            context.Vendors.Add(ven);
            context.SaveChanges();
        }

        // Updates provided vendor
        public static void Update(Vendor ven)
        {
            var context = new AssetContext();
            var existingVen = context.Vendors.SingleOrDefault(v => v.Id == ven.Id);

            existingVen.Name = ven.Name;
            context.SaveChanges();
        }

        // To be used on necessity instead of EF
        private static List<Vendor> LoadTestData()
        {
            var vendors = new List<Vendor>();

            vendors.Add(new Vendor { Id = 1, Name = "FireBlue Security", PhoneNumber = "832-762-2971" });
            vendors.Add(new Vendor { Id = 2, Name = "BitRate Computers", PhoneNumber = "403-321-9452" });
            vendors.Add(new Vendor { Id = 3, Name = "Crystal Voice Coms", PhoneNumber = "587-902-7821" });

            return vendors;
        }
    }
}
