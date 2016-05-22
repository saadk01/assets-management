using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPRG254.Assets.Domain
{
    public class Vendor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }

        public virtual IEnumerable<Asset> Assets { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
