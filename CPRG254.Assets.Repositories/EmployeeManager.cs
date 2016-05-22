using CPRG254.Assets.Data;
using CPRG254.Assets.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPRG254.Assets.Repositories
{
    public class EmployeeManager : Employee
    {
        public static IEnumerable<Employee> GetAll()
        {
            // The following line of code is to be un-commented if there's no Entity Framework
            // (The EF usage then should naturally be commented out).
            // var employees = LoadTestData();

            var context = new AssetContext();
            var employees = context.Employees.ToList();

            return employees;
        }

        // Adds employee to the system
        public static void Add(Employee emp)
        {
            var context = new AssetContext();
            context.Employees.Add(emp);
            context.SaveChanges();
        }

        // Updates provided employee
        public static void Update(Employee emp)
        {
            var context = new AssetContext();
            var existingEmp = context.Employees.SingleOrDefault(e => e.Id == emp.Id);

            existingEmp.FirstName = emp.FirstName;
            existingEmp.LastName = emp.LastName;
            existingEmp.HireDate = emp.HireDate;
            existingEmp.DeskNumber = emp.DeskNumber;
            existingEmp.PhoneNumber = emp.PhoneNumber;
            existingEmp.DepartmentId = emp.DepartmentId;
            context.SaveChanges();
        }

        // To be used on necessity instead of EF
        private static List<Employee> LoadTestData()
        {
            var employees = new List<Employee>();

            employees.Add(
                new Employee {
                    Id = 1,
                    FirstName = "Damien",
                    LastName = "Fleming",
                    HireDate = new DateTime(2010, 12, 27),
                    DeskNumber = "ACC-03",
                    PhoneNumber = "403-928-7623",
                    DepartmentId = 1
            });
            employees.Add(
                new Employee {
                    Id = 2,
                    FirstName = "Karen",
                    LastName = "Lee",
                    HireDate = new DateTime(2012, 1, 11),
                    DeskNumber = "ENG-12",
                    PhoneNumber = "587-432-8821",
                    DepartmentId = 2
            });
            employees.Add(
                new Employee {
                    Id = 3,
                    FirstName = "Ted",
                    LastName = "Jacobs",
                    HireDate = new DateTime(2013, 8, 2),
                    DeskNumber = "SAL-08",
                    PhoneNumber = "403-226-2823",
                    DepartmentId = 3
            });

            return employees;
        }
    }
}
