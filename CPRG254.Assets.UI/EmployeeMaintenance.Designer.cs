namespace CPRG254.Assets.UI
{
    partial class EmployeeMaintenance
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.uxFName = new System.Windows.Forms.TextBox();
            this.uxLName = new System.Windows.Forms.TextBox();
            this.uxDeskNum = new System.Windows.Forms.TextBox();
            this.uxHireDate = new System.Windows.Forms.DateTimePicker();
            this.uxTel = new System.Windows.Forms.TextBox();
            this.uxDept = new System.Windows.Forms.ComboBox();
            this.uxCancel = new System.Windows.Forms.Button();
            this.uxOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(379, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Last Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Desk Number:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(379, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Phone Number:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Date of Hire:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(379, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Department:";
            // 
            // uxFName
            // 
            this.uxFName.Location = new System.Drawing.Point(127, 30);
            this.uxFName.Name = "uxFName";
            this.uxFName.Size = new System.Drawing.Size(158, 20);
            this.uxFName.TabIndex = 6;
            // 
            // uxLName
            // 
            this.uxLName.Location = new System.Drawing.Point(487, 30);
            this.uxLName.Name = "uxLName";
            this.uxLName.Size = new System.Drawing.Size(158, 20);
            this.uxLName.TabIndex = 7;
            // 
            // uxDeskNum
            // 
            this.uxDeskNum.Location = new System.Drawing.Point(127, 79);
            this.uxDeskNum.Name = "uxDeskNum";
            this.uxDeskNum.Size = new System.Drawing.Size(158, 20);
            this.uxDeskNum.TabIndex = 8;
            // 
            // uxHireDate
            // 
            this.uxHireDate.Location = new System.Drawing.Point(127, 127);
            this.uxHireDate.Name = "uxHireDate";
            this.uxHireDate.Size = new System.Drawing.Size(158, 20);
            this.uxHireDate.TabIndex = 12;
            // 
            // uxTel
            // 
            this.uxTel.Location = new System.Drawing.Point(487, 79);
            this.uxTel.Name = "uxTel";
            this.uxTel.Size = new System.Drawing.Size(158, 20);
            this.uxTel.TabIndex = 10;
            // 
            // uxDept
            // 
            this.uxDept.FormattingEnabled = true;
            this.uxDept.Location = new System.Drawing.Point(487, 127);
            this.uxDept.Name = "uxDept";
            this.uxDept.Size = new System.Drawing.Size(158, 21);
            this.uxDept.TabIndex = 13;
            // 
            // uxCancel
            // 
            this.uxCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.uxCancel.Location = new System.Drawing.Point(570, 179);
            this.uxCancel.Name = "uxCancel";
            this.uxCancel.Size = new System.Drawing.Size(75, 23);
            this.uxCancel.TabIndex = 18;
            this.uxCancel.Text = "&Cancel";
            this.uxCancel.UseVisualStyleBackColor = true;
            this.uxCancel.Click += new System.EventHandler(this.uxCancel_Click);
            // 
            // uxOk
            // 
            this.uxOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.uxOk.Location = new System.Drawing.Point(463, 179);
            this.uxOk.Name = "uxOk";
            this.uxOk.Size = new System.Drawing.Size(75, 23);
            this.uxOk.TabIndex = 17;
            this.uxOk.Text = "&OK";
            this.uxOk.UseVisualStyleBackColor = true;
            this.uxOk.Click += new System.EventHandler(this.uxOk_Click);
            // 
            // EmployeeMaintenance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 226);
            this.Controls.Add(this.uxCancel);
            this.Controls.Add(this.uxOk);
            this.Controls.Add(this.uxDept);
            this.Controls.Add(this.uxTel);
            this.Controls.Add(this.uxHireDate);
            this.Controls.Add(this.uxDeskNum);
            this.Controls.Add(this.uxLName);
            this.Controls.Add(this.uxFName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "EmployeeMaintenance";
            this.Text = "EmployeeMaintenance";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox uxFName;
        private System.Windows.Forms.TextBox uxLName;
        private System.Windows.Forms.TextBox uxDeskNum;
        private System.Windows.Forms.DateTimePicker uxHireDate;
        private System.Windows.Forms.TextBox uxTel;
        private System.Windows.Forms.ComboBox uxDept;
        private System.Windows.Forms.Button uxCancel;
        private System.Windows.Forms.Button uxOk;
    }
}