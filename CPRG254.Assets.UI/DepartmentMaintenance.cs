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
    public partial class DepartmentMaintenance : Form
    {
        public Department Department { get; set; }

        public DepartmentMaintenance()
        {
            InitializeComponent();
            Text = "Add New Department";
        }

        public DepartmentMaintenance(Department dept)
        {
            InitializeComponent();
            Department = dept;
            uxDeptName.Text = Department.Name;
            Text = "Edit Department";
        }

        private void uxCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void uxOk_Click(object sender, EventArgs e)
        {
            if (Department == null)
            {
                // doing an insert
                Department = new Department();
                Department.Name = uxDeptName.Text;
                DepartmentManager.Add(Department);
            }
            else
            {
                // doing an update
                Department.Name = uxDeptName.Text;
                DepartmentManager.Update(Department);
            }
            Close();
        }
    }
}
