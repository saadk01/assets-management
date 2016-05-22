using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPRG254.Assets.Domain
{
    public class Asset
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Serial { get; set; }

        public int VendorId { get; set; }
        public System.Nullable<int> EmployeeId { get; set; }
        public System.Nullable<DateTime> DateAssigned { get; set; }
        public int AssetCategoryId { get; set; }
        
        public virtual Employee Employee { get; set; }
        public virtual Vendor Vendor { get; set; }
        public virtual AssetCategory AssetCategory { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
