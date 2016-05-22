using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CPRG254.Assets.Repositories;
using CPRG254.Assets.Domain;

namespace CPRG254.Assets.UI
{
    public partial class VendorMaintenance : Form
    {
        public Vendor Vendor { get; set; }
        public VendorMaintenance()
        {
            InitializeComponent();
            Text = "Add New Vendor";
        }

        public VendorMaintenance(Vendor ven)
        {
            InitializeComponent();
            Vendor = ven;
            uxVendorName.Text = Vendor.Name;
            uxVendorPhone.Text = Vendor.PhoneNumber;
            Text = "Edit Vendor";
        }

        private void uxOk_Click(object sender, EventArgs e)
        {
            if (Vendor == null)
            {
                // doing an insert
                Vendor = new Vendor();
                Vendor.Name = uxVendorName.Text;
                Vendor.PhoneNumber = uxVendorPhone.Text;
                VendorManager.Add(Vendor);
            }
            else
            {
                // doing an update
                Vendor.Name = uxVendorName.Text;
                Vendor.PhoneNumber = uxVendorPhone.Text;
                VendorManager.Update(Vendor);
            }
            Close();
        }

        private void uxCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
