namespace CPRG254.Assets.UI
{
    partial class VendorMaintenance
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
            this.uxCancel = new System.Windows.Forms.Button();
            this.uxOk = new System.Windows.Forms.Button();
            this.uxVendorName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.uxVendorPhone = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // uxCancel
            // 
            this.uxCancel.Location = new System.Drawing.Point(193, 117);
            this.uxCancel.Name = "uxCancel";
            this.uxCancel.Size = new System.Drawing.Size(75, 23);
            this.uxCancel.TabIndex = 15;
            this.uxCancel.Text = "&Cancel";
            this.uxCancel.UseVisualStyleBackColor = true;
            this.uxCancel.Click += new System.EventHandler(this.uxCancel_Click);
            // 
            // uxOk
            // 
            this.uxOk.Location = new System.Drawing.Point(105, 117);
            this.uxOk.Name = "uxOk";
            this.uxOk.Size = new System.Drawing.Size(75, 23);
            this.uxOk.TabIndex = 14;
            this.uxOk.Text = "&OK";
            this.uxOk.UseVisualStyleBackColor = true;
            this.uxOk.Click += new System.EventHandler(this.uxOk_Click);
            // 
            // uxVendorName
            // 
            this.uxVendorName.Location = new System.Drawing.Point(105, 21);
            this.uxVendorName.Name = "uxVendorName";
            this.uxVendorName.Size = new System.Drawing.Size(163, 20);
            this.uxVendorName.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Phone:";
            // 
            // uxVendorPhone
            // 
            this.uxVendorPhone.Location = new System.Drawing.Point(105, 64);
            this.uxVendorPhone.Name = "uxVendorPhone";
            this.uxVendorPhone.Size = new System.Drawing.Size(163, 20);
            this.uxVendorPhone.TabIndex = 13;
            // 
            // VendorMaintenance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 159);
            this.Controls.Add(this.uxVendorPhone);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.uxCancel);
            this.Controls.Add(this.uxOk);
            this.Controls.Add(this.uxVendorName);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "VendorMaintenance";
            this.Text = "VendorMaintenance";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button uxCancel;
        private System.Windows.Forms.Button uxOk;
        private System.Windows.Forms.TextBox uxVendorName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox uxVendorPhone;
    }
}