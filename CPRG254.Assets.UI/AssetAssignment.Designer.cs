namespace CPRG254.Assets.UI
{
    partial class AssetAssignment
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.uxEmployees = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.uxCancel = new System.Windows.Forms.Button();
            this.uxOk = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.uxCategories = new System.Windows.Forms.ComboBox();
            this.uxEmployeeAssets = new System.Windows.Forms.CheckedListBox();
            this.uxAvailableAssets = new System.Windows.Forms.CheckedListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.uxSuccessMessage = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.uxDepartmentName = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // uxEmployees
            // 
            this.uxEmployees.FormattingEnabled = true;
            this.uxEmployees.Location = new System.Drawing.Point(213, 23);
            this.uxEmployees.Name = "uxEmployees";
            this.uxEmployees.Size = new System.Drawing.Size(253, 21);
            this.uxEmployees.TabIndex = 0;
            this.uxEmployees.SelectionChangeCommitted += new System.EventHandler(this.uxEmployees_SelectionChangeCommitted);
            this.uxEmployees.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.uxEmployees_Format);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select Employee:";
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(248, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(2, 391);
            this.label2.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.uxSuccessMessage);
            this.panel1.Controls.Add(this.uxCancel);
            this.panel1.Controls.Add(this.uxOk);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 524);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(505, 58);
            this.panel1.TabIndex = 3;
            // 
            // uxCancel
            // 
            this.uxCancel.Location = new System.Drawing.Point(389, 21);
            this.uxCancel.Name = "uxCancel";
            this.uxCancel.Size = new System.Drawing.Size(75, 23);
            this.uxCancel.TabIndex = 5;
            this.uxCancel.Text = "&Done";
            this.uxCancel.UseVisualStyleBackColor = true;
            this.uxCancel.Click += new System.EventHandler(this.uxCancel_Click);
            // 
            // uxOk
            // 
            this.uxOk.Location = new System.Drawing.Point(294, 21);
            this.uxOk.Name = "uxOk";
            this.uxOk.Size = new System.Drawing.Size(75, 23);
            this.uxOk.TabIndex = 4;
            this.uxOk.Text = "&Save";
            this.uxOk.UseVisualStyleBackColor = true;
            this.uxOk.Click += new System.EventHandler(this.uxOk_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(62, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Assigned Assets";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(311, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Available Assets";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(272, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "Category:";
            // 
            // uxCategories
            // 
            this.uxCategories.FormattingEnabled = true;
            this.uxCategories.Location = new System.Drawing.Point(345, 139);
            this.uxCategories.Name = "uxCategories";
            this.uxCategories.Size = new System.Drawing.Size(121, 21);
            this.uxCategories.TabIndex = 8;
            this.uxCategories.SelectionChangeCommitted += new System.EventHandler(this.uxCategories_SelectionChangeCommitted);
            // 
            // uxEmployeeAssets
            // 
            this.uxEmployeeAssets.FormattingEnabled = true;
            this.uxEmployeeAssets.Location = new System.Drawing.Point(41, 196);
            this.uxEmployeeAssets.Name = "uxEmployeeAssets";
            this.uxEmployeeAssets.Size = new System.Drawing.Size(191, 244);
            this.uxEmployeeAssets.TabIndex = 9;
            // 
            // uxAvailableAssets
            // 
            this.uxAvailableAssets.FormattingEnabled = true;
            this.uxAvailableAssets.Location = new System.Drawing.Point(275, 226);
            this.uxAvailableAssets.Name = "uxAvailableAssets";
            this.uxAvailableAssets.Size = new System.Drawing.Size(191, 214);
            this.uxAvailableAssets.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Liberation Mono", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(41, 141);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(191, 32);
            this.label6.TabIndex = 11;
            this.label6.Text = "Uncheck those assets that you want returned.";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Liberation Mono", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(272, 180);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(194, 32);
            this.label7.TabIndex = 12;
            this.label7.Text = "Check those assets that you want assigned.";
            // 
            // uxSuccessMessage
            // 
            this.uxSuccessMessage.AutoSize = true;
            this.uxSuccessMessage.Font = new System.Drawing.Font("Linux Biolinum G", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxSuccessMessage.ForeColor = System.Drawing.Color.Green;
            this.uxSuccessMessage.Location = new System.Drawing.Point(36, 21);
            this.uxSuccessMessage.Name = "uxSuccessMessage";
            this.uxSuccessMessage.Size = new System.Drawing.Size(183, 18);
            this.uxSuccessMessage.TabIndex = 6;
            this.uxSuccessMessage.Text = "Changes saved successfully.";
            this.uxSuccessMessage.Visible = false;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Liberation Mono", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(41, 481);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(425, 29);
            this.label8.TabIndex = 13;
            this.label8.Text = "Press \'Save\' each time before changing category (if you have added new assets). P" +
    "ress \'Done\' when finished.";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(185, 60);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Department:";
            // 
            // uxDepartmentName
            // 
            this.uxDepartmentName.AutoSize = true;
            this.uxDepartmentName.Location = new System.Drawing.Point(256, 60);
            this.uxDepartmentName.Name = "uxDepartmentName";
            this.uxDepartmentName.Size = new System.Drawing.Size(101, 13);
            this.uxDepartmentName.TabIndex = 15;
            this.uxDepartmentName.Text = "uxDepartmentName";
            // 
            // AssetAssignment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 582);
            this.Controls.Add(this.uxDepartmentName);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.uxAvailableAssets);
            this.Controls.Add(this.uxEmployeeAssets);
            this.Controls.Add(this.uxCategories);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uxEmployees);
            this.MaximizeBox = false;
            this.Name = "AssetAssignment";
            this.Text = "Asset Assignment to Employees";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox uxEmployees;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox uxCategories;
        private System.Windows.Forms.Button uxCancel;
        private System.Windows.Forms.Button uxOk;
        private System.Windows.Forms.CheckedListBox uxEmployeeAssets;
        private System.Windows.Forms.CheckedListBox uxAvailableAssets;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label uxSuccessMessage;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label uxDepartmentName;
    }
}