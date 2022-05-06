
namespace WindowsFormsApp
{
    partial class Deparment1
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
            this.btnBinaryWrite = new System.Windows.Forms.Button();
            this.btnBinaryRead = new System.Windows.Forms.Button();
            this.btnXmlWrite = new System.Windows.Forms.Button();
            this.btnXmlRead = new System.Windows.Forms.Button();
            this.btnSoapWrite = new System.Windows.Forms.Button();
            this.btnSoapRead = new System.Windows.Forms.Button();
            this.btnJsonWrite = new System.Windows.Forms.Button();
            this.btnJsonRead = new System.Windows.Forms.Button();
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
            // btnBinaryWrite
            // 
            this.btnBinaryWrite.Location = new System.Drawing.Point(534, 74);
            this.btnBinaryWrite.Name = "btnBinaryWrite";
            this.btnBinaryWrite.Size = new System.Drawing.Size(110, 23);
            this.btnBinaryWrite.TabIndex = 10;
            this.btnBinaryWrite.Text = "Binary Write";
            this.btnBinaryWrite.UseVisualStyleBackColor = true;
            this.btnBinaryWrite.Click += new System.EventHandler(this.btnBinaryWrite_Click);
            // 
            // btnBinaryRead
            // 
            this.btnBinaryRead.Location = new System.Drawing.Point(534, 103);
            this.btnBinaryRead.Name = "btnBinaryRead";
            this.btnBinaryRead.Size = new System.Drawing.Size(110, 23);
            this.btnBinaryRead.TabIndex = 11;
            this.btnBinaryRead.Text = "Binary Read";
            this.btnBinaryRead.UseVisualStyleBackColor = true;
            this.btnBinaryRead.Click += new System.EventHandler(this.btnBinaryRead_Click);
            // 
            // btnXmlWrite
            // 
            this.btnXmlWrite.Location = new System.Drawing.Point(534, 132);
            this.btnXmlWrite.Name = "btnXmlWrite";
            this.btnXmlWrite.Size = new System.Drawing.Size(110, 23);
            this.btnXmlWrite.TabIndex = 12;
            this.btnXmlWrite.Text = "XML Write";
            this.btnXmlWrite.UseVisualStyleBackColor = true;
            this.btnXmlWrite.Click += new System.EventHandler(this.btnXmlWrite_Click);
            // 
            // btnXmlRead
            // 
            this.btnXmlRead.Location = new System.Drawing.Point(534, 161);
            this.btnXmlRead.Name = "btnXmlRead";
            this.btnXmlRead.Size = new System.Drawing.Size(110, 23);
            this.btnXmlRead.TabIndex = 13;
            this.btnXmlRead.Text = "XML Read";
            this.btnXmlRead.UseVisualStyleBackColor = true;
            this.btnXmlRead.Click += new System.EventHandler(this.btnXmlRead_Click);
            // 
            // btnSoapWrite
            // 
            this.btnSoapWrite.Location = new System.Drawing.Point(534, 185);
            this.btnSoapWrite.Name = "btnSoapWrite";
            this.btnSoapWrite.Size = new System.Drawing.Size(110, 23);
            this.btnSoapWrite.TabIndex = 14;
            this.btnSoapWrite.Text = "SOAP Write";
            this.btnSoapWrite.UseVisualStyleBackColor = true;
            this.btnSoapWrite.Click += new System.EventHandler(this.btnSoapWrite_Click);
            // 
            // btnSoapRead
            // 
            this.btnSoapRead.Location = new System.Drawing.Point(534, 215);
            this.btnSoapRead.Name = "btnSoapRead";
            this.btnSoapRead.Size = new System.Drawing.Size(110, 23);
            this.btnSoapRead.TabIndex = 15;
            this.btnSoapRead.Text = "SOAP Read";
            this.btnSoapRead.UseVisualStyleBackColor = true;
            this.btnSoapRead.Click += new System.EventHandler(this.btnSoapRead_Click);
            // 
            // btnJsonWrite
            // 
            this.btnJsonWrite.Location = new System.Drawing.Point(534, 244);
            this.btnJsonWrite.Name = "btnJsonWrite";
            this.btnJsonWrite.Size = new System.Drawing.Size(110, 23);
            this.btnJsonWrite.TabIndex = 16;
            this.btnJsonWrite.Text = "JSON Write";
            this.btnJsonWrite.UseVisualStyleBackColor = true;
            this.btnJsonWrite.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnJsonRead
            // 
            this.btnJsonRead.Location = new System.Drawing.Point(534, 276);
            this.btnJsonRead.Name = "btnJsonRead";
            this.btnJsonRead.Size = new System.Drawing.Size(110, 23);
            this.btnJsonRead.TabIndex = 17;
            this.btnJsonRead.Text = "JSON Read";
            this.btnJsonRead.UseVisualStyleBackColor = true;
            this.btnJsonRead.Click += new System.EventHandler(this.btnJsonRead_Click);
            // 
            // Deparment1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnJsonRead);
            this.Controls.Add(this.btnJsonWrite);
            this.Controls.Add(this.btnSoapRead);
            this.Controls.Add(this.btnSoapWrite);
            this.Controls.Add(this.btnXmlRead);
            this.Controls.Add(this.btnXmlWrite);
            this.Controls.Add(this.btnBinaryRead);
            this.Controls.Add(this.btnBinaryWrite);
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
            this.Name = "Deparment1";
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
        private System.Windows.Forms.Button btnBinaryWrite;
        private System.Windows.Forms.Button btnBinaryRead;
        private System.Windows.Forms.Button btnXmlWrite;
        private System.Windows.Forms.Button btnXmlRead;
        private System.Windows.Forms.Button btnSoapWrite;
        private System.Windows.Forms.Button btnSoapRead;
        private System.Windows.Forms.Button btnJsonWrite;
        private System.Windows.Forms.Button btnJsonRead;
    }
}