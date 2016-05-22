using CPRG254.Assets.Domain;
using CPRG254.Assets.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPRG254.Assets.Repositories
{
    public class AssetManager : Asset
    {
        public static IEnumerable<Asset> GetAll()
        {
            // The following line of code is to be un-commented if there's no Entity Framework
            // (The EF usage then should naturally be commented out).
            // var assets = LoadTestData();

            var context = new AssetContext();
            var assets = context.Assets.ToList();
            
            return assets;
        }

        // Adds asset to the system
        public static void Add(Asset asset)
        {
            var context = new AssetContext();
            context.Assets.Add(asset);
            context.SaveChanges();
        }

        // Updates provided asset
        public static void Update(Asset asset)
        {
            var context = new AssetContext();
            var existingAsset = context.Assets.SingleOrDefault(a => a.Id == asset.Id);

            existingAsset.Name = asset.Name;
            existingAsset.Description = asset.Description;
            existingAsset.Serial = asset.Serial;
            existingAsset.VendorId = asset.VendorId;
            existingAsset.AssetCategoryId = asset.AssetCategoryId;
            context.SaveChanges();
        }

        // Gets assets for the given employee ID
        public static IEnumerable<Asset> GetAssetsByEmployee(int employeeId)
        {
            var context = new AssetContext();

            return context.Assets.Where(a => a.EmployeeId == employeeId).ToList();
        }

        // Gets assets for the given asset category ID
        public static IEnumerable<Asset> GetAvailableAssetsByCategory(int categoryId)
        {
            var context = new AssetContext();

            return context.Assets.
                Where(a => a.AssetCategoryId == categoryId).
                Where(a => a.EmployeeId == null).
                ToList(); 
        }

        // Remove an asset from its assigned employee
        public static void RemoveAssetFromEmployee(int assetId)
        {
            var context = new AssetContext();
            Asset ast = context.Assets.SingleOrDefault(a => a.Id == assetId);
            ast.EmployeeId = null;
            ast.DateAssigned = null;
            context.SaveChanges();
        }

        // Assign an asset to a given employee
        public static void AssignAssetsToEmployee(int assetId, int employeeId)
        {
            var context = new AssetContext();
            Asset ast = context.Assets.SingleOrDefault(a => a.Id == assetId);
            ast.EmployeeId = employeeId;
            ast.DateAssigned = DateTime.Now;
            context.SaveChanges();
        }

        // Check if any of the given asset category's asset is already assigned to given employee
        public static bool CategoryAssetAlreadyAssignedToEmployee(int assetCategoryId, int employeeId)
        {
            var context = new AssetContext();
            var assets = context.Assets.
                Where(a => a.AssetCategoryId == assetCategoryId).
                Where(a => a.EmployeeId == employeeId).
                ToList();

            if (assets.Count > 0)
            {
                return true;
            }

            return false;
        }

        // To be used on necessity instead of EF
        private static List<Asset> LoadTestData()
        {
            var assets = new List<Asset>();

            assets.Add(new Asset
            {
                Id = 1,
                Name = "Intel Core i7 Desktop",
                Description = "Desktop for Engineering Department",
                Serial = "IC7ENG-001",
                VendorId = 1,
                AssetCategoryId = 1
            });
            assets.Add(new Asset
            {
                Id = 2,
                Name = "Nasio Full Accounting",
                Description = "Accounting Calculator",
                Serial = "NFAACAL-001",
                VendorId = 2,
                AssetCategoryId = 2
            });
            assets.Add(new Asset
            {
                Id = 3,
                Name = "Twinkle Telephone and Fax System",
                Description = "Telephone and fax system for Sales Department",
                Serial = "TTFSAL-001",
                VendorId = 3,
                AssetCategoryId = 3
            });

            return assets;
        }
    }
}
