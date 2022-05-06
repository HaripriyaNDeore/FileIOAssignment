
namespace WindowsFormsApp
{
    partial class Employee
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
            this.lblEmpId = new System.Windows.Forms.Label();
            this.lblEmpNm = new System.Windows.Forms.Label();
            this.lblDesi = new System.Windows.Forms.Label();
            this.lblSalary = new System.Windows.Forms.Label();
            this.lblDept = new System.Windows.Forms.Label();
            this.txtEmpId = new System.Windows.Forms.TextBox();
            this.txtEmpNm = new System.Windows.Forms.TextBox();
            this.txtDesig = new System.Windows.Forms.TextBox();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.txtDept = new System.Windows.Forms.TextBox();
            this.btnWriteFile = new System.Windows.Forms.Button();
            this.btnReadFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblEmpId
            // 
            this.lblEmpId.AutoSize = true;
            this.lblEmpId.Location = new System.Drawing.Point(244, 53);
            this.lblEmpId.Name = "lblEmpId";
            this.lblEmpId.Size = new System.Drawing.Size(65, 13);
            this.lblEmpId.TabIndex = 0;
            this.lblEmpId.Text = "Employee Id";
            this.lblEmpId.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblEmpNm
            // 
            this.lblEmpNm.AutoSize = true;
            this.lblEmpNm.Location = new System.Drawing.Point(244, 97);
            this.lblEmpNm.Name = "lblEmpNm";
            this.lblEmpNm.Size = new System.Drawing.Size(84, 13);
            this.lblEmpNm.TabIndex = 1;
            this.lblEmpNm.Text = "Employee Name";
            // 
            // lblDesi
            // 
            this.lblDesi.AutoSize = true;
            this.lblDesi.Location = new System.Drawing.Point(244, 137);
            this.lblDesi.Name = "lblDesi";
            this.lblDesi.Size = new System.Drawing.Size(63, 13);
            this.lblDesi.TabIndex = 2;
            this.lblDesi.Text = "Designation";
            // 
            // lblSalary
            // 
            this.lblSalary.AutoSize = true;
            this.lblSalary.Location = new System.Drawing.Point(244, 176);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(36, 13);
            this.lblSalary.TabIndex = 3;
            this.lblSalary.Text = "Salary";
            this.lblSalary.Click += new System.EventHandler(this.label4_Click);
            // 
            // lblDept
            // 
            this.lblDept.AutoSize = true;
            this.lblDept.Location = new System.Drawing.Point(244, 217);
            this.lblDept.Name = "lblDept";
            this.lblDept.Size = new System.Drawing.Size(62, 13);
            this.lblDept.TabIndex = 4;
            this.lblDept.Text = "Department";
            this.lblDept.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtEmpId
            // 
            this.txtEmpId.Location = new System.Drawing.Point(343, 45);
            this.txtEmpId.Name = "txtEmpId";
            this.txtEmpId.Size = new System.Drawing.Size(100, 20);
            this.txtEmpId.TabIndex = 5;
            this.txtEmpId.TextChanged += new System.EventHandler(this.txtEmpId_TextChanged);
            // 
            // txtEmpNm
            // 
            this.txtEmpNm.Location = new System.Drawing.Point(343, 97);
            this.txtEmpNm.Name = "txtEmpNm";
            this.txtEmpNm.Size = new System.Drawing.Size(100, 20);
            this.txtEmpNm.TabIndex = 6;
            // 
            // txtDesig
            // 
            this.txtDesig.Location = new System.Drawing.Point(343, 137);
            this.txtDesig.Name = "txtDesig";
            this.txtDesig.Size = new System.Drawing.Size(100, 20);
            this.txtDesig.TabIndex = 7;
            // 
            // txtSalary
            // 
            this.txtSalary.Location = new System.Drawing.Point(343, 176);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(100, 20);
            this.txtSalary.TabIndex = 8;
            // 
            // txtDept
            // 
            this.txtDept.Location = new System.Drawing.Point(343, 217);
            this.txtDept.Name = "txtDept";
            this.txtDept.Size = new System.Drawing.Size(100, 20);
            this.txtDept.TabIndex = 9;
            // 
            // btnWriteFile
            // 
            this.btnWriteFile.Location = new System.Drawing.Point(247, 278);
            this.btnWriteFile.Name = "btnWriteFile";
            this.btnWriteFile.Size = new System.Drawing.Size(90, 23);
            this.btnWriteFile.TabIndex = 10;
            this.btnWriteFile.Text = "Write To File";
            this.btnWriteFile.UseVisualStyleBackColor = true;
            this.btnWriteFile.Click += new System.EventHandler(this.btnWriteFile_Click);
            // 
            // btnReadFile
            // 
            this.btnReadFile.Location = new System.Drawing.Point(343, 278);
            this.btnReadFile.Name = "btnReadFile";
            this.btnReadFile.Size = new System.Drawing.Size(100, 23);
            this.btnReadFile.TabIndex = 11;
            this.btnReadFile.Text = "Read From File";
            this.btnReadFile.UseVisualStyleBackColor = true;
            this.btnReadFile.Click += new System.EventHandler(this.btnReadFile_Click);
            // 
            // Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnReadFile);
            this.Controls.Add(this.btnWriteFile);
            this.Controls.Add(this.txtDept);
            this.Controls.Add(this.txtSalary);
            this.Controls.Add(this.txtDesig);
            this.Controls.Add(this.txtEmpNm);
            this.Controls.Add(this.txtEmpId);
            this.Controls.Add(this.lblDept);
            this.Controls.Add(this.lblSalary);
            this.Controls.Add(this.lblDesi);
            this.Controls.Add(this.lblEmpNm);
            this.Controls.Add(this.lblEmpId);
            this.Name = "Employee";
            this.Text = "Employee Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEmpId;
        private System.Windows.Forms.Label lblEmpNm;
        private System.Windows.Forms.Label lblDesi;
        private System.Windows.Forms.Label lblSalary;
        private System.Windows.Forms.Label lblDept;
        private System.Windows.Forms.TextBox txtEmpId;
        private System.Windows.Forms.TextBox txtEmpNm;
        private System.Windows.Forms.TextBox txtDesig;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.TextBox txtDept;
        private System.Windows.Forms.Button btnWriteFile;
        private System.Windows.Forms.Button btnReadFile;
    }
}