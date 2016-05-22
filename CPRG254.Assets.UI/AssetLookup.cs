using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CPRG254.Assets.Domain;
using CPRG254.Assets.Repositories;

namespace CPRG254.Assets.UI
{
    public partial class AssetLookup : Form
    {
        public AssetLookup()
        {
            InitializeComponent();
            PopulateAssets();
        }

        private void PopulateAssets()
        {
            uxAssets.DataSource = AssetManager.GetAll();
            uxAssets.Columns[0].Visible = false;
            uxAssets.Columns[4].Visible = false;
            uxAssets.Columns[5].Visible = false;
            uxAssets.Columns[7].Visible = false;

            uxAssets.Columns[1].Width = 150;
            uxAssets.Columns[2].Width = 300;
            uxAssets.Columns[3].Width = 200;
        }

        private void addAssignToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new AssetMaintenance();
            frm.ShowDialog();
            PopulateAssets();
        }

        private void editAssignToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // get asset from the grid
            var asset = (Asset)uxAssets.CurrentRow.DataBoundItem;

            // pass it to the constructor of the maintenance form
            var frm = new AssetMaintenance(asset);
            frm.ShowDialog();
            PopulateAssets();
        }
    }
}
