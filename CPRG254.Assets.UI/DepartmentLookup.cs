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
    public partial class DepartmentLookup : Form
    {
        public DepartmentLookup()
        {
            InitializeComponent();
            PopulateDepartments();
        }

        private void PopulateDepartments()
        {
            uxDepartments.DataSource = DepartmentManager.GetAll();
            uxDepartments.Columns[0].Visible = false;
            uxDepartments.Columns[2].Visible = false;
            uxDepartments.Columns[1].Width = 200;
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new DepartmentMaintenance();
            frm.ShowDialog();
            PopulateDepartments();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // get department from the grid
            var dept = (Department)uxDepartments.CurrentRow.DataBoundItem;

            // pass it to the constructor of the maintenance form
            var frm = new DepartmentMaintenance(dept);
            frm.ShowDialog();
            PopulateDepartments();
        }
    }
}
