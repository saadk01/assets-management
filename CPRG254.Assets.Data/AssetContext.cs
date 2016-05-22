using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CPRG254.Assets.Domain;
using System.Data.Entity;

namespace CPRG254.Assets.Data
{
    public class AssetContext : DbContext
    {
        public DbSet<Department> Departments { get; set; }
        public object Employee { get; internal set; }
        public DbSet<Employee> Employees { get; set; }
        public object Asset { get; internal set; }
        public DbSet<Asset> Assets { get; set; }
        public DbSet<AssetCategory> AssetCategories { get; set; }
        public DbSet<Vendor> Vendors { get; set; }
    }
}
