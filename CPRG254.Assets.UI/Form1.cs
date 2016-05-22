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
    public partial class Form1 : Form
    {
        DepartmentLookup _deptLookupForm;
        EmployeeLookup _empLookupForm;
        AssetCategoryLookup _aCatLookupForm;
        VendorLookup _venLookupForm;
        AssetLookup _astLookupForm;
        AssetAssignment _astAsgnLookupForm;

        public Form1()
        {
            InitializeComponent();
        }

        // Employee Lookup Form
        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_empLookupForm == null || _empLookupForm.IsDisposed)
            {
                _empLookupForm = new EmployeeLookup();
                _empLookupForm.MdiParent = this;
            }

            _empLookupForm.Show();
            _empLookupForm.BringToFront();
        }

        // Department Lookup Form
        private void addToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (_deptLookupForm == null || _deptLookupForm.IsDisposed)
            {
                _deptLookupForm = new DepartmentLookup();
                _deptLookupForm.MdiParent = this;
            }

            _deptLookupForm.Show();
            _deptLookupForm.BringToFront();
        }

        // Asset Categories Lookup Form
        private void addToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (_aCatLookupForm == null || _aCatLookupForm.IsDisposed)
            {
                _aCatLookupForm = new AssetCategoryLookup();
                _aCatLookupForm.MdiParent = this;
            }

            _aCatLookupForm.Show();
            _aCatLookupForm.BringToFront();
        }

        // Vendor Lookup Form
        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_venLookupForm == null || _venLookupForm.IsDisposed)
            {
                _venLookupForm = new VendorLookup();
                _venLookupForm.MdiParent = this;
            }

            _venLookupForm.Show();
            _venLookupForm.BringToFront();
        }

        // Assets Lookup Form
        private void viewToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (_astLookupForm == null || _astLookupForm.IsDisposed)
            {
                _astLookupForm = new AssetLookup();
                _astLookupForm.MdiParent = this;
            }

            _astLookupForm.Show();
            _astLookupForm.BringToFront();
        }

        //  Asset Assignment Form
        private void manageAssignmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_astAsgnLookupForm == null || _astAsgnLookupForm.IsDisposed)
            {
                _astAsgnLookupForm = new AssetAssignment();
                _astAsgnLookupForm.MdiParent = this;
            }

            _astAsgnLookupForm.Show();
            _astAsgnLookupForm.BringToFront();
        }

        // Toolstrip buttons
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            addToolStripMenuItem_Click(sender, e);
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            addToolStripMenuItem1_Click(sender, e);
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            viewToolStripMenuItem1_Click(sender, e);
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            addToolStripMenuItem2_Click(sender, e);
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            viewToolStripMenuItem_Click(sender, e);
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            manageAssignmentToolStripMenuItem_Click(sender, e);
        }
        // END: Toolstrip buttons

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
