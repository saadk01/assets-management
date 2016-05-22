using CPRG254.Assets.Domain;
using CPRG254.Assets.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CPRG254.Assets.UI
{
    public partial class AssetCategoryLookup : Form
    {
        public AssetCategoryLookup()
        {
            InitializeComponent();
            PopulateAssetCategories();
        }

        private void PopulateAssetCategories()
        {
            uxACats.DataSource = AssetCategoryManager.GetAll();
            uxACats.Columns[0].Visible = false;
            uxACats.Columns[2].Visible = false;
            uxACats.Columns[1].Width = 200;
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new AssetCategoryMaintenance();
            frm.ShowDialog();
            PopulateAssetCategories();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // get category from the grid
            var aCat = (AssetCategory)uxACats.CurrentRow.DataBoundItem;

            // pass it to the constructor of the maintenance form
            var frm = new AssetCategoryMaintenance(aCat);
            frm.ShowDialog();
            PopulateAssetCategories();
        }
    }
}
