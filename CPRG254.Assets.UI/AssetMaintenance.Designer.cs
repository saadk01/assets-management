namespace CPRG254.Assets.UI
{
    partial class AssetMaintenance
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
            this.uxAstName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.uxAstSer = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.uxAstDesc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.uxAstVen = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.uxAstCat = new System.Windows.Forms.ComboBox();
            this.uxCancel = new System.Windows.Forms.Button();
            this.uxOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // uxAstName
            // 
            this.uxAstName.Location = new System.Drawing.Point(112, 24);
            this.uxAstName.Name = "uxAstName";
            this.uxAstName.Size = new System.Drawing.Size(137, 20);
            this.uxAstName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(308, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Serial:";
            // 
            // uxAstSer
            // 
            this.uxAstSer.Location = new System.Drawing.Point(377, 24);
            this.uxAstSer.Name = "uxAstSer";
            this.uxAstSer.Size = new System.Drawing.Size(137, 20);
            this.uxAstSer.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Description:";
            // 
            // uxAstDesc
            // 
            this.uxAstDesc.Location = new System.Drawing.Point(112, 79);
            this.uxAstDesc.Multiline = true;
            this.uxAstDesc.Name = "uxAstDesc";
            this.uxAstDesc.Size = new System.Drawing.Size(137, 73);
            this.uxAstDesc.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(308, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Vendor:";
            // 
            // uxAstVen
            // 
            this.uxAstVen.FormattingEnabled = true;
            this.uxAstVen.Location = new System.Drawing.Point(377, 79);
            this.uxAstVen.Name = "uxAstVen";
            this.uxAstVen.Size = new System.Drawing.Size(137, 21);
            this.uxAstVen.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(308, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Category:";
            // 
            // uxAstCat
            // 
            this.uxAstCat.FormattingEnabled = true;
            this.uxAstCat.Location = new System.Drawing.Point(377, 131);
            this.uxAstCat.Name = "uxAstCat";
            this.uxAstCat.Size = new System.Drawing.Size(137, 21);
            this.uxAstCat.TabIndex = 9;
            // 
            // uxCancel
            // 
            this.uxCancel.Location = new System.Drawing.Point(439, 184);
            this.uxCancel.Name = "uxCancel";
            this.uxCancel.Size = new System.Drawing.Size(75, 23);
            this.uxCancel.TabIndex = 11;
            this.uxCancel.Text = "&Cancel";
            this.uxCancel.UseVisualStyleBackColor = true;
            this.uxCancel.Click += new System.EventHandler(this.uxCancel_Click);
            // 
            // uxOk
            // 
            this.uxOk.Location = new System.Drawing.Point(311, 184);
            this.uxOk.Name = "uxOk";
            this.uxOk.Size = new System.Drawing.Size(75, 23);
            this.uxOk.TabIndex = 10;
            this.uxOk.Text = "&OK";
            this.uxOk.UseVisualStyleBackColor = true;
            this.uxOk.Click += new System.EventHandler(this.uxOk_Click);
            // 
            // AssetMaintenance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 230);
            this.Controls.Add(this.uxCancel);
            this.Controls.Add(this.uxOk);
            this.Controls.Add(this.uxAstCat);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.uxAstVen);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.uxAstDesc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.uxAstSer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.uxAstName);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "AssetMaintenance";
            this.Text = "AssetMaintenance";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox uxAstName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox uxAstSer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox uxAstDesc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox uxAstVen;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox uxAstCat;
        private System.Windows.Forms.Button uxCancel;
        private System.Windows.Forms.Button uxOk;
    }
}