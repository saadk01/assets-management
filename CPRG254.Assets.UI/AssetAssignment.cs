using CPRG254.Assets.Repositories;
using CPRG254.Assets.Domain;
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
    public partial class AssetAssignment : Form
    {
        public AssetAssignment()
        {
            InitializeComponent();
            PopulateInitialData();
        }

        private void PopulateInitialData()
        {
            uxEmployees.DataSource = EmployeeManager.GetAll();
            uxEmployees.ValueMember = "Id";
            uxEmployees.DisplayMember = "LastName";
            uxCategories.DataSource = AssetCategoryManager.GetAll();
            uxCategories.DisplayMember = "Name";
            uxCategories.ValueMember = "Id";

            var firstEmployeeAssets = AssetManager.GetAssetsByEmployee(EmployeeManager.GetAll().First().Id);          
            var firstCategoryAssets = AssetManager.GetAvailableAssetsByCategory(AssetCategoryManager.GetAll().First().Id);
            PopulateEmployeeAssets(firstEmployeeAssets);
            PopulateCategoryAssets(firstCategoryAssets);
            uxDepartmentName.Text = EmployeeManager.GetAll().First().Department.ToString();
        }

        private void PopulateEmployeeAssets(IEnumerable<Asset> EmployeeAssets)
        {
            foreach (Asset ast in EmployeeAssets)
            {
                uxEmployeeAssets.Items.Add(ast, true);
            }
        }

        private void PopulateCategoryAssets(IEnumerable<Asset> CategoryAssets)
        {
            foreach (Asset ast in CategoryAssets)
            {
                uxAvailableAssets.Items.Add(ast, false);
            }
        }

        // Enable an employee's complete name to appear in the combobox as compared to just first 
        // or last name via 'DisplayMember' (http://stackoverflow.com/a/18817375/1420170)
        private void uxEmployees_Format(object sender, ListControlConvertEventArgs e)
        {
            string fName = ((Employee)e.ListItem).FirstName;
            string lName = ((Employee)e.ListItem).LastName;
            e.Value = lName + ", " + fName;
        }

        private void uxEmployees_SelectionChangeCommitted(object sender, EventArgs e)
        {
            var selectedEmployee = (Employee)uxEmployees.SelectedItem;
            uxEmployeeAssets.Items.Clear();
            var selectedEmployeeAssets = AssetManager.GetAssetsByEmployee(selectedEmployee.Id);
            PopulateEmployeeAssets(selectedEmployeeAssets);
            uxDepartmentName.Text = selectedEmployee.Department.ToString();
        }

        private void uxCategories_SelectionChangeCommitted(object sender, EventArgs e)
        {
            var selectedCategory = (AssetCategory)uxCategories.SelectedItem;
            uxAvailableAssets.Items.Clear();
            var selectedCategoryAssets = AssetManager.GetAvailableAssetsByCategory(selectedCategory.Id);
            PopulateCategoryAssets(selectedCategoryAssets);
        }

        private void uxCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void uxOk_Click(object sender, EventArgs e)
        {
            try
            {
                // 1) Get current employee andselected category
                var selectedEmployee = (Employee)uxEmployees.SelectedItem;
                var selectedCategory = (AssetCategory)uxCategories.SelectedItem;

                // 2-A) Get items that should be taken away from this employee (http://stackoverflow.com/a/30264947/1420170)
                IEnumerable<Asset> uncheckedAssets = (from Asset item in uxEmployeeAssets.Items
                                                      where !uxEmployeeAssets.CheckedItems.Contains(item)
                                                      select item);

                // 2-B) Remove these assets
                foreach (Asset ast in uncheckedAssets)
                {
                    AssetManager.RemoveAssetFromEmployee(ast.Id);
                }

                // 3-A) Get items that should be assigned to this employee
                IEnumerable<Asset> checkedAssets = (from Asset item in uxAvailableAssets.Items
                                                    where uxAvailableAssets.CheckedItems.Contains(item)
                                                    select item);
                if (checkedAssets.Count() > 0) {
                    // 3-B) More than one asset from a given category can't be assigned to this employee
                    // 3-B-i) Check if more than one asset within a category is checked
                    if (checkedAssets.Count() > 1)
                    {
                        throw new Exception("You can only assign one asset from each category to an employee.");
                    }

                    // 3-B-ii) For the given category, make sure no related asset is already assigned
                    bool alreadyAssigned = AssetManager.CategoryAssetAlreadyAssignedToEmployee(selectedCategory.Id, selectedEmployee.Id);

                    if (alreadyAssigned == true)
                    {
                        throw new Exception("You can only assign one asset from each category to an employee.");
                    }

                    // 3-C) Assign this asset
                    foreach (Asset ast in checkedAssets)
                    {
                        AssetManager.AssignAssetsToEmployee(ast.Id, selectedEmployee.Id);
                    }
                }

                // 4) Display success message for 2s (http://stackoverflow.com/a/15951830/1420170)
                var t = new Timer();
                t.Interval = 2000;
                t.Tick += (s, ev) =>
                {
                    uxSuccessMessage.Hide();
                    t.Stop();
                };
                uxSuccessMessage.Show();
                t.Start();

                // 5) Repopulate the checlistboxes
                uxEmployeeAssets.Items.Clear();
                uxAvailableAssets.Items.Clear();
                var selectedEmployeeAssets = AssetManager.GetAssetsByEmployee(selectedEmployee.Id);
                PopulateEmployeeAssets(selectedEmployeeAssets);
                var selectedCategoryAssets = AssetManager.GetAvailableAssetsByCategory(selectedCategory.Id);
                PopulateCategoryAssets(selectedCategoryAssets);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
