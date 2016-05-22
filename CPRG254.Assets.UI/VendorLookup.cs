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
    public partial class VendorLookup : Form
    {
        public VendorLookup()
        {
            InitializeComponent();
            PopulateVendors();
        }

        private void PopulateVendors()
        {
            uxVendors.DataSource = VendorManager.GetAll();
            uxVendors.Columns[0].Visible = false;
            uxVendors.Columns[3].Visible = false;
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new VendorMaintenance();
            frm.ShowDialog();
            PopulateVendors();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // get vendor from the grid
            var ven = (Vendor)uxVendors.CurrentRow.DataBoundItem;

            // pass it to the constructor of the maintenance form
            var frm = new VendorMaintenance(ven);
            frm.ShowDialog();
            PopulateVendors();
        }
    }
}
