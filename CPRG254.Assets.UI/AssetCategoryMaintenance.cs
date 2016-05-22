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
    public partial class AssetCategoryMaintenance : Form
    {
        public AssetCategory AsCat { get; set; }

        public AssetCategoryMaintenance()
        {
            InitializeComponent();
            Text = "Add New Asset Category";
        }

        public AssetCategoryMaintenance(AssetCategory aCat)
        {
            InitializeComponent();
            AsCat = aCat;
            uxACatName.Text = AsCat.Name;
            Text = "Edit Asset Category";
        }

        private void uxOk_Click(object sender, EventArgs e)
        {
            if (AsCat == null)
            {
                // doing an insert
                AsCat = new AssetCategory();
                AsCat.Name = uxACatName.Text;
                AssetCategoryManager.Add(AsCat);
            }
            else
            {
                // doing an update
                AsCat.Name = uxACatName.Text;
                AssetCategoryManager.Update(AsCat);
            }
            Close();
        }

        private void uxCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
