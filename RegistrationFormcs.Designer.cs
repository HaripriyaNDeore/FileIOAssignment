
namespace WindowsFormsApp
{
    partial class RegistrationFormcs
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
            this.lblFName = new System.Windows.Forms.Label();
            this.lblEmailId = new System.Windows.Forms.Label();
            this.lblContactNo = new System.Windows.Forms.Label();
            this.txtFName = new System.Windows.Forms.TextBox();
            this.txtEmailId = new System.Windows.Forms.TextBox();
            this.txtContactNo = new System.Windows.Forms.TextBox();
            this.lblAdd = new System.Windows.Forms.Label();
            this.txtAdd = new System.Windows.Forms.TextBox();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblshow = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblFName
            // 
            this.lblFName.AutoSize = true;
            this.lblFName.Location = new System.Drawing.Point(238, 73);
            this.lblFName.Name = "lblFName";
            this.lblFName.Size = new System.Drawing.Size(54, 13);
            this.lblFName.TabIndex = 0;
            this.lblFName.Text = "Full Name";
            this.lblFName.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblEmailId
            // 
            this.lblEmailId.AutoSize = true;
            this.lblEmailId.Location = new System.Drawing.Point(238, 124);
            this.lblEmailId.Name = "lblEmailId";
            this.lblEmailId.Size = new System.Drawing.Size(44, 13);
            this.lblEmailId.TabIndex = 1;
            this.lblEmailId.Text = "Email Id";
            this.lblEmailId.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblContactNo
            // 
            this.lblContactNo.AutoSize = true;
            this.lblContactNo.Location = new System.Drawing.Point(238, 176);
            this.lblContactNo.Name = "lblContactNo";
            this.lblContactNo.Size = new System.Drawing.Size(84, 13);
            this.lblContactNo.TabIndex = 2;
            this.lblContactNo.Text = "Contact Number";
            this.lblContactNo.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtFName
            // 
            this.txtFName.Location = new System.Drawing.Point(367, 66);
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(100, 20);
            this.txtFName.TabIndex = 3;
            this.txtFName.TextChanged += new System.EventHandler(this.txtFName_TextChanged);
            // 
            // txtEmailId
            // 
            this.txtEmailId.Location = new System.Drawing.Point(367, 117);
            this.txtEmailId.Name = "txtEmailId";
            this.txtEmailId.Size = new System.Drawing.Size(100, 20);
            this.txtEmailId.TabIndex = 4;
            this.txtEmailId.TextChanged += new System.EventHandler(this.txtEmailId_TextChanged);
            // 
            // txtContactNo
            // 
            this.txtContactNo.Location = new System.Drawing.Point(367, 169);
            this.txtContactNo.Name = "txtContactNo";
            this.txtContactNo.Size = new System.Drawing.Size(100, 20);
            this.txtContactNo.TabIndex = 5;
            this.txtContactNo.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // lblAdd
            // 
            this.lblAdd.AutoSize = true;
            this.lblAdd.Location = new System.Drawing.Point(238, 230);
            this.lblAdd.Name = "lblAdd";
            this.lblAdd.Size = new System.Drawing.Size(45, 13);
            this.lblAdd.TabIndex = 6;
            this.lblAdd.Text = "Address";
            // 
            // txtAdd
            // 
            this.txtAdd.Location = new System.Drawing.Point(367, 223);
            this.txtAdd.Name = "txtAdd";
            this.txtAdd.Size = new System.Drawing.Size(100, 20);
            this.txtAdd.TabIndex = 7;
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(241, 292);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(75, 23);
            this.btnShow.TabIndex = 8;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(392, 292);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblshow
            // 
            this.lblshow.AutoSize = true;
            this.lblshow.Location = new System.Drawing.Point(323, 347);
            this.lblshow.Name = "lblshow";
            this.lblshow.Size = new System.Drawing.Size(0, 13);
            this.lblshow.TabIndex = 10;
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(347, 332);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(60, 13);
            this.lblData.TabIndex = 11;
            this.lblData.Text = "Show Data";
            this.lblData.Click += new System.EventHandler(this.lblData_Click);
            // 
            // RegistrationFormcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.lblshow);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.txtAdd);
            this.Controls.Add(this.lblAdd);
            this.Controls.Add(this.txtContactNo);
            this.Controls.Add(this.txtEmailId);
            this.Controls.Add(this.txtFName);
            this.Controls.Add(this.lblContactNo);
            this.Controls.Add(this.lblEmailId);
            this.Controls.Add(this.lblFName);
            this.Name = "RegistrationFormcs";
            this.Text = "RegistrationFormcs";
            this.Load += new System.EventHandler(this.RegistrationFormcs_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFName;
        private System.Windows.Forms.Label lblEmailId;
        private System.Windows.Forms.Label lblContactNo;
        private System.Windows.Forms.TextBox txtFName;
        private System.Windows.Forms.TextBox txtEmailId;
        private System.Windows.Forms.TextBox txtContactNo;
        private System.Windows.Forms.Label lblAdd;
        private System.Windows.Forms.TextBox txtAdd;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblshow;
        private System.Windows.Forms.Label lblData;
    }
}