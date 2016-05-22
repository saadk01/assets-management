namespace CPRG254.Assets.Data.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using CPRG254.Assets.Domain;

    internal sealed class Configuration : DbMigrationsConfiguration<CPRG254.Assets.Data.AssetContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(CPRG254.Assets.Data.AssetContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            var departments = new Department[] {
                new Department { Name = "Accounting" },
                new Department { Name = "Engineering" },
                new Department { Name = "Sales" }
            };

            context.Departments.AddOrUpdate(d => d.Name, departments);
            context.SaveChanges();

            var dept1 = context.Departments.Find(1);
            var dept2 = context.Departments.Find(2);
            var dept3 = context.Departments.Find(3);

            var employees = new Employee[] {
                new Employee {
                    FirstName = "Damien",
                    LastName = "Fleming",
                    HireDate = new DateTime(2010, 12, 27),
                    DeskNumber = "ACC-03",
                    PhoneNumber = "403-928-7623",
                    Department = dept1
                },
                new Employee {
                    FirstName = "Karen",
                    LastName = "Lee",
                    HireDate = new DateTime(2012, 1, 11),
                    DeskNumber = "ENG-12",
                    PhoneNumber = "587-432-8821",
                    Department = dept2
                },
                new Employee {
                    FirstName = "Ted",
                    LastName = "Jacobs",
                    HireDate = new DateTime(2013, 8, 2),
                    DeskNumber = "SAL-08",
                    PhoneNumber = "403-226-2823",
                    Department = dept3
                }
            };

            context.Employees.AddOrUpdate(e => e.DeskNumber, employees);
            context.SaveChanges();

            var vendors = new Vendor[] {
                new Vendor { Name = "BitRate Computers", PhoneNumber = "403-321-9452" },
                new Vendor { Name = "Nasio Electronics", PhoneNumber = "832-762-2971" },
                new Vendor { Name = "Crystal Voice Coms", PhoneNumber = "587-902-7821" }
            };

            context.Vendors.AddOrUpdate(v => v.Name, vendors);
            context.SaveChanges();

            var assetCategories = new AssetCategory[] {
                new AssetCategory { Name = "Desktop PCs" },
                new AssetCategory { Name = "Calculators" },
                new AssetCategory { Name = "Telephones" }
            };

            context.AssetCategories.AddOrUpdate(ac => ac.Name, assetCategories);
            context.SaveChanges();

            var employee1 = context.Employees.Find(1);
            var employee2 = context.Employees.Find(2);
            var employee3 = context.Employees.Find(3);

            var vendor1 = context.Vendors.Find(1);
            var vendor2 = context.Vendors.Find(2);
            var vendor3 = context.Vendors.Find(3);

            var aCat1 = context.AssetCategories.Find(1);
            var aCat2 = context.AssetCategories.Find(2);
            var aCat3 = context.AssetCategories.Find(3);

            var assets = new Asset[] {
                new Asset {
                    Name = "Intel Core i7 Desktop",
                    Description = "Desktop for Engineering Department",
                    Serial = "IC7ENG-001",
                    Vendor = vendor1,
                    AssetCategory = aCat1,
                    Employee = employee2,
                    DateAssigned = new DateTime(2015,12,1)
                },
                new Asset {
                    Id = 2,
                    Name = "Nasio Full Accounting",
                    Description = "Accounting Calculator",
                    Serial = "NFAACAL-001",
                    Vendor = vendor2,
                    AssetCategory = aCat2,
                    Employee = employee1,
                    DateAssigned = new DateTime(2015,6,17)
                },
                new Asset {
                    Id = 3,
                    Name = "Twinkle Telephone and Fax System",
                    Description = "Telephone and fax system for Sales Department",
                    Serial = "TTFSAL-001",
                    Vendor = vendor3,
                    AssetCategory = aCat3,
                    Employee = employee3,
                    DateAssigned = new DateTime(2015,9,3)
                }
            };

            context.Assets.AddOrUpdate(a => a.Serial, assets);
            context.SaveChanges();
        }
    }
}
