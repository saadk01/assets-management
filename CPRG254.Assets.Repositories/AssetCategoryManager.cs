using CPRG254.Assets.Domain;
using CPRG254.Assets.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPRG254.Assets.Repositories
{
    public class AssetCategoryManager: AssetCategory
    {
        public static IEnumerable<AssetCategory> GetAll()
        {
            // The following line of code is to be un-commented if there's no Entity Framework
            // (The EF usage then should naturally be commented out).
            // var categories = LoadTestData();

            var context = new AssetContext();
            var categories = context.AssetCategories.ToList();
            
            return categories;
        }

        // Adds asset category to the system
        public static void Add(AssetCategory aCat)
        {
            var context = new AssetContext();
            context.AssetCategories.Add(aCat);
            context.SaveChanges();
        }

        // Updates provided asset category
        public static void Update(AssetCategory aCat)
        {
            var context = new AssetContext();
            var existingACat = context.AssetCategories.SingleOrDefault(ac => ac.Id == aCat.Id);

            existingACat.Name = aCat.Name;
            context.SaveChanges();
        }

        // To be used on necessity instead of EF
        private static List<AssetCategory> LoadTestData()
        {
            var categories = new List<AssetCategory>();

            categories.Add(new AssetCategory { Id = 1, Name = "Desktop PCs" });
            categories.Add(new AssetCategory { Id = 2, Name = "Calculators" });
            categories.Add(new AssetCategory { Id = 3, Name = "Telephones" });

            return categories;
        }
    }
}

