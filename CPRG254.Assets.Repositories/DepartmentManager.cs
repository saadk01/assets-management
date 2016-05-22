using CPRG254.Assets.Data;
using CPRG254.Assets.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPRG254.Assets.Repositories
{
    public class DepartmentManager : Department
    {
       public static IEnumerable<Department> GetAll()
        {
            // The following line of code is to be un-commented if there's no Entity Framework
            // (The EF usage then should naturally be commented out).
            // var departments = LoadTestData();

            var context = new AssetContext();
            var departments = context.Departments.ToList();

            return departments;
        }

        // Adds department to the system
        public static void Add(Department dept)
        {
            var context = new AssetContext();
            context.Departments.Add(dept);
            context.SaveChanges();
        }

        // Updates provided department
        public static void Update(Department dept)
        {
            var context = new AssetContext();
            var existingDept = context.Departments.SingleOrDefault(d => d.Id == dept.Id);

            existingDept.Name = dept.Name;
            context.SaveChanges();
        }

        // To be used on necessity instead of EF
        private static List<Department> LoadTestData()
        {
            var departments = new List<Department>();

            departments.Add(new Department { Id = 1, Name = "Accounting" });
            departments.Add(new Department { Id = 2, Name = "Engineering" });
            departments.Add(new Department { Id = 3, Name = "Sales" });

            return departments;
        }
    }
}
