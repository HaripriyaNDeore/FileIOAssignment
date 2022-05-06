using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp
{
    public partial class StudentForm : Form
    {
        FileStream fs;
        public StudentForm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtRno_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                String path = @"D:\DemoFolder";
                if (Directory.Exists(path))
                {
                    MessageBox.Show("Folder Already Exist");
                }
                else
                {
                    Directory.CreateDirectory(path);
                    MessageBox.Show("Folder Created");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lblShowRecord_Click(object sender, EventArgs e)
        {
            lblShowRecord.Text = ($"Roll No={txtRno.Text} Student Name={txtName.Text } Percentage={ txtPerc.Text } Straem={ txtStream.Text }City={ txtCity.Text }"); 
        }

        private void txtStream_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                int rollno = Convert.ToInt32(txtRno.Text);
                String name = txtName.Text; 
                decimal percentage = Convert.ToDecimal(txtPerc.Text);
                String Streamm = txtStream.Text;
                String City = txtCity.Text;
                fs = new FileStream(@"D:\DemoFolder\StudentFile.txt", FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                txtRno.Text = br.ReadInt32().ToString();
                txtName.Text = br.ToString();
                txtPerc.Text = br.ToString().ToString();
                txtStream.Text = br.ToString();
                txtCity.Text = br.ToString();
                br.Close();
                MessageBox.Show("Done");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                fs.Close();
            }
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            try
            {
                int rollno = Convert.ToInt32(txtRno.Text);
                String name = txtName.Text;
                decimal percentage = Convert.ToDecimal(txtPerc.Text);
                String stream = txtStream.Text;
                String city = txtCity.Text;
                fs = new FileStream(@"D:\DemoFolder\StudentFile.txt", FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                txtRno.Text = br.ReadInt32().ToString();
                txtName.Text = br.ReadString();
                txtPerc.Text = br.ReadDecimal().ToString();
                txtStream.Text = br.ReadString();
                txtCity.Text = br.ReadString();
                br.Close();
                MessageBox.Show("Done");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                fs.Close();
            }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            txtRno.Clear();
            txtName.Clear();
            txtPerc.Clear();
            txtStream.Clear();
            txtCity.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int rollno = Convert.ToInt32(txtRno.Text);
                String name = txtName.Text;
                decimal percentage = Convert.ToDecimal(txtPerc.Text);
                String stream = txtStream.Text;
                String city = txtCity.Text;
                fs = new FileStream(@"D:\DemoFolder\StudentFile.txt", FileMode.Create, FileAccess.Write);
                BinaryWriter bw = new BinaryWriter(fs);
                bw.Write(rollno);
                bw.Write(name);
                bw.Write(percentage);  
                bw.Write(stream);
                bw.Write(city);
                bw.Close();
                MessageBox.Show("Done");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                fs.Close();
            }
        }
    }
}
