using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPRG254.Assets.Domain
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual IEnumerable<Employee> Employees { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
