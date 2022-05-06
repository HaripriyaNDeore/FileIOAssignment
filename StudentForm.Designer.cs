
namespace WindowsFormsApp
{
    partial class StudentForm
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
            this.lblRNo = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPerc = new System.Windows.Forms.Label();
            this.lblStream = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.txtRno = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPerc = new System.Windows.Forms.TextBox();
            this.txtStream = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnRead = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.lblShowRecord = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblRNo
            // 
            this.lblRNo.AutoSize = true;
            this.lblRNo.Location = new System.Drawing.Point(228, 59);
            this.lblRNo.Name = "lblRNo";
            this.lblRNo.Size = new System.Drawing.Size(42, 13);
            this.lblRNo.TabIndex = 0;
            this.lblRNo.Text = "Roll No";
            this.lblRNo.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(228, 93);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name";
            this.lblName.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblPerc
            // 
            this.lblPerc.AutoSize = true;
            this.lblPerc.Location = new System.Drawing.Point(228, 132);
            this.lblPerc.Name = "lblPerc";
            this.lblPerc.Size = new System.Drawing.Size(62, 13);
            this.lblPerc.TabIndex = 2;
            this.lblPerc.Text = "Percentage";
            // 
            // lblStream
            // 
            this.lblStream.AutoSize = true;
            this.lblStream.Location = new System.Drawing.Point(228, 172);
            this.lblStream.Name = "lblStream";
            this.lblStream.Size = new System.Drawing.Size(40, 13);
            this.lblStream.TabIndex = 3;
            this.lblStream.Text = "Stream";
            this.lblStream.Click += new System.EventHandler(this.label4_Click);
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(228, 210);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(24, 13);
            this.lblCity.TabIndex = 4;
            this.lblCity.Text = "City";
            this.lblCity.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtRno
            // 
            this.txtRno.Location = new System.Drawing.Point(368, 52);
            this.txtRno.Name = "txtRno";
            this.txtRno.Size = new System.Drawing.Size(100, 20);
            this.txtRno.TabIndex = 5;
            this.txtRno.TextChanged += new System.EventHandler(this.txtRno_TextChanged);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(368, 90);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 6;
            // 
            // txtPerc
            // 
            this.txtPerc.Location = new System.Drawing.Point(368, 129);
            this.txtPerc.Name = "txtPerc";
            this.txtPerc.Size = new System.Drawing.Size(100, 20);
            this.txtPerc.TabIndex = 7;
            // 
            // txtStream
            // 
            this.txtStream.Location = new System.Drawing.Point(368, 169);
            this.txtStream.Name = "txtStream";
            this.txtStream.Size = new System.Drawing.Size(100, 20);
            this.txtStream.TabIndex = 8;
            this.txtStream.TextChanged += new System.EventHandler(this.txtStream_TextChanged);
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(368, 207);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(100, 20);
            this.txtCity.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(231, 253);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Write To File";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(368, 252);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(99, 23);
            this.btnRead.TabIndex = 11;
            this.btnRead.Text = "Read From File";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(231, 304);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(84, 23);
            this.button3.TabIndex = 12;
            this.button3.Text = "Create Folder";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(378, 303);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(88, 23);
            this.button4.TabIndex = 13;
            this.button4.Text = "Create File";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(378, 350);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(88, 23);
            this.Clear.TabIndex = 14;
            this.Clear.Text = "Clear Record";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // lblShowRecord
            // 
            this.lblShowRecord.AutoSize = true;
            this.lblShowRecord.Location = new System.Drawing.Point(228, 375);
            this.lblShowRecord.Name = "lblShowRecord";
            this.lblShowRecord.Size = new System.Drawing.Size(72, 13);
            this.lblShowRecord.TabIndex = 15;
            this.lblShowRecord.Text = "Show Record";
            this.lblShowRecord.Click += new System.EventHandler(this.lblShowRecord_Click);
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblShowRecord);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.txtStream);
            this.Controls.Add(this.txtPerc);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtRno);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.lblStream);
            this.Controls.Add(this.lblPerc);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblRNo);
            this.Name = "StudentForm";
            this.Text = "Student Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRNo;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPerc;
        private System.Windows.Forms.Label lblStream;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.TextBox txtRno;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPerc;
        private System.Windows.Forms.TextBox txtStream;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Label lblShowRecord;
    }
}