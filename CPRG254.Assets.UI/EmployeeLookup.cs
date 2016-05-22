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
    public partial class EmployeeLookup : Form
    {
        public EmployeeLookup()
        {
            InitializeComponent();
            PopulateEmployees();
        }

        private void PopulateEmployees()
        {
            uxEmployees.DataSource = EmployeeManager.GetAll();
            uxEmployees.Columns[0].Visible = false;
            uxEmployees.Columns[6].Visible = false;
            uxEmployees.Columns[8].Visible = false;
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // get employee from the grid
            var emp = (Employee)uxEmployees.CurrentRow.DataBoundItem;

            // pass it to the constrocutor of the maintenance form
            var frm = new EmployeeMaintenance(emp);
            frm.ShowDialog();
            PopulateEmployees();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new EmployeeMaintenance();
            frm.ShowDialog();
            PopulateEmployees();
        }
    }
}
