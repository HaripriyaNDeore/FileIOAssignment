
namespace WindowsFormsApp
{
    partial class Deparment
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
            this.lblDeptId = new System.Windows.Forms.Label();
            this.lblDeptNm = new System.Windows.Forms.Label();
            this.txtbDeptId = new System.Windows.Forms.TextBox();
            this.txtbDeptNm = new System.Windows.Forms.TextBox();
            this.txtbDeptLoc = new System.Windows.Forms.TextBox();
            this.lblDeptLoc = new System.Windows.Forms.Label();
            this.btnWrToFi = new System.Windows.Forms.Button();
            this.btnReadFromFile = new System.Windows.Forms.Button();
            this.btnCreateFolder = new System.Windows.Forms.Button();
            this.btnCreateFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDeptId
            // 
            this.lblDeptId.AutoSize = true;
            this.lblDeptId.Location = new System.Drawing.Point(249, 78);
            this.lblDeptId.Name = "lblDeptId";
            this.lblDeptId.Size = new System.Drawing.Size(102, 13);
            this.lblDeptId.TabIndex = 0;
            this.lblDeptId.Text = "Enter Department Id";
            this.lblDeptId.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblDeptNm
            // 
            this.lblDeptNm.AutoSize = true;
            this.lblDeptNm.Location = new System.Drawing.Point(249, 134);
            this.lblDeptNm.Name = "lblDeptNm";
            this.lblDeptNm.Size = new System.Drawing.Size(93, 13);
            this.lblDeptNm.TabIndex = 1;
            this.lblDeptNm.Text = "Department Name";
            // 
            // txtbDeptId
            // 
            this.txtbDeptId.Location = new System.Drawing.Point(369, 78);
            this.txtbDeptId.Name = "txtbDeptId";
            this.txtbDeptId.Size = new System.Drawing.Size(100, 20);
            this.txtbDeptId.TabIndex = 2;
            this.txtbDeptId.TextChanged += new System.EventHandler(this.txtbDeptId_TextChanged);
            // 
            // txtbDeptNm
            // 
            this.txtbDeptNm.Location = new System.Drawing.Point(369, 131);
            this.txtbDeptNm.Name = "txtbDeptNm";
            this.txtbDeptNm.Size = new System.Drawing.Size(100, 20);
            this.txtbDeptNm.TabIndex = 3;
            // 
            // txtbDeptLoc
            // 
            this.txtbDeptLoc.Location = new System.Drawing.Point(369, 189);
            this.txtbDeptLoc.Name = "txtbDeptLoc";
            this.txtbDeptLoc.Size = new System.Drawing.Size(100, 20);
            this.txtbDeptLoc.TabIndex = 4;
            this.txtbDeptLoc.TextChanged += new System.EventHandler(this.txtbDeptLoc_TextChanged);
            // 
            // lblDeptLoc
            // 
            this.lblDeptLoc.AutoSize = true;
            this.lblDeptLoc.Location = new System.Drawing.Point(249, 189);
            this.lblDeptLoc.Name = "lblDeptLoc";
            this.lblDeptLoc.Size = new System.Drawing.Size(106, 13);
            this.lblDeptLoc.TabIndex = 5;
            this.lblDeptLoc.Text = "Department Location";
            // 
            // btnWrToFi
            // 
            this.btnWrToFi.Location = new System.Drawing.Point(252, 239);
            this.btnWrToFi.Name = "btnWrToFi";
            this.btnWrToFi.Size = new System.Drawing.Size(90, 23);
            this.btnWrToFi.TabIndex = 6;
            this.btnWrToFi.Text = "Write To File";
            this.btnWrToFi.UseVisualStyleBackColor = true;
            this.btnWrToFi.Click += new System.EventHandler(this.btnWrToFi_Click);
            // 
            // btnReadFromFile
            // 
            this.btnReadFromFile.Location = new System.Drawing.Point(371, 239);
            this.btnReadFromFile.Name = "btnReadFromFile";
            this.btnReadFromFile.Size = new System.Drawing.Size(98, 23);
            this.btnReadFromFile.TabIndex = 7;
            this.btnReadFromFile.Text = "Read From File";
            this.btnReadFromFile.UseVisualStyleBackColor = true;
            this.btnReadFromFile.Click += new System.EventHandler(this.btnReadFromFile_Click);
            // 
            // btnCreateFolder
            // 
            this.btnCreateFolder.Location = new System.Drawing.Point(252, 286);
            this.btnCreateFolder.Name = "btnCreateFolder";
            this.btnCreateFolder.Size = new System.Drawing.Size(99, 23);
            this.btnCreateFolder.TabIndex = 8;
            this.btnCreateFolder.Text = "Create Folder";
            this.btnCreateFolder.UseVisualStyleBackColor = true;
            this.btnCreateFolder.Click += new System.EventHandler(this.btnCreateFolder_Click);
            // 
            // btnCreateFile
            // 
            this.btnCreateFile.Location = new System.Drawing.Point(371, 286);
            this.btnCreateFile.Name = "btnCreateFile";
            this.btnCreateFile.Size = new System.Drawing.Size(98, 23);
            this.btnCreateFile.TabIndex = 9;
            this.btnCreateFile.Text = "Create File";
            this.btnCreateFile.UseVisualStyleBackColor = true;
            this.btnCreateFile.Click += new System.EventHandler(this.btnCreateFile_Click);
            // 
            // Deparment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCreateFile);
            this.Controls.Add(this.btnCreateFolder);
            this.Controls.Add(this.btnReadFromFile);
            this.Controls.Add(this.btnWrToFi);
            this.Controls.Add(this.lblDeptLoc);
            this.Controls.Add(this.txtbDeptLoc);
            this.Controls.Add(this.txtbDeptNm);
            this.Controls.Add(this.txtbDeptId);
            this.Controls.Add(this.lblDeptNm);
            this.Controls.Add(this.lblDeptId);
            this.Name = "Deparment";
            this.Text = "File IO";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDeptId;
        private System.Windows.Forms.Label lblDeptNm;
        private System.Windows.Forms.TextBox txtbDeptId;
        private System.Windows.Forms.TextBox txtbDeptNm;
        private System.Windows.Forms.TextBox txtbDeptLoc;
        private System.Windows.Forms.Label lblDeptLoc;
        private System.Windows.Forms.Button btnWrToFi;
        private System.Windows.Forms.Button btnReadFromFile;
        private System.Windows.Forms.Button btnCreateFolder;
        private System.Windows.Forms.Button btnCreateFile;
    }
}