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
    public partial class AssetMaintenance : Form
    {
        public Asset Asset { get; set; }

        public AssetMaintenance()
        {
            InitializeComponent();
            PopulateVendorsAndCategories();
            Text = "Add New Asset";
        }

        public AssetMaintenance(Asset ast)
        {
            InitializeComponent();
            Asset = ast;
            PopulateVendorsAndCategories();
            PopulateFields();
            Text = "Edit Asset";
        }

        private void PopulateVendorsAndCategories()
        {
            uxAstVen.DataSource = VendorManager.GetAll();
            uxAstVen.DisplayMember = "Name";
            uxAstVen.ValueMember = "Id";
            uxAstCat.DataSource = AssetCategoryManager.GetAll();
            uxAstCat.DisplayMember = "Name";
            uxAstCat.ValueMember = "Id";
        }
        
        private void PopulateFields()
        {
            uxAstName.Text = Asset.Name;
            uxAstSer.Text = Asset.Serial;
            uxAstDesc.Text = Asset.Description;
            uxAstVen.SelectedValue = Asset.VendorId;
            uxAstCat.SelectedValue = Asset.AssetCategoryId;
        }

        private void uxOk_Click(object sender, EventArgs e)
        {
            if (Asset == null)
            {
                // doing an insert
                Asset = new Asset();
                SetAsset();
                AssetManager.Add(Asset);
            }
            else
            {
                // doing an update
                SetAsset();
                AssetManager.Update(Asset);
            }
            Close();
        }

        private void SetAsset()
        {
            Asset.Name = uxAstName.Text;
            Asset.Serial = uxAstSer.Text;
            Asset.Description = uxAstDesc.Text;
            Asset.VendorId = (int)uxAstVen.SelectedValue;
            Asset.AssetCategoryId = (int)uxAstCat.SelectedValue;
        }

        private void uxCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
