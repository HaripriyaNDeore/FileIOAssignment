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
    public partial class Employee : Form
    {
        FileStream fs;
        public Employee()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnWriteFile_Click(object sender, EventArgs e)
        {
            try
            {
                int empid = Convert.ToInt32(txtEmpId.Text);
                String ename = txtEmpNm.Text;
                String designation = txtDesig.Text;
                long salary = Convert.ToInt64(txtSalary.Text);
                String dept = txtDept.Text;
                fs = new FileStream(@"D:\DemoFolder\EmployeeData.txt", FileMode.Create, FileAccess.Write);
                BinaryWriter bw = new BinaryWriter(fs);
                bw.Write(empid);
                bw.Write(ename);
                bw.Write(designation);
                bw.Write(salary);
                bw.Write(dept);
                bw.Close();
                MessageBox.Show("Done!! Record Inserted Successfully");
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

        private void btnReadFile_Click(object sender, EventArgs e)
        {
            try
            {
                int empid = Convert.ToInt32(txtEmpId.Text);
                String ename = txtEmpNm.Text;
                String designation = txtDesig.Text;
                long salary = Convert.ToInt64(txtSalary.Text);
                String dept = txtDept.Text;
                fs = new FileStream(@"D:\DemoFolder\EmployeeData.txt", FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                txtEmpId.Text = br.ReadInt32().ToString();
                txtEmpNm.Text = br.ReadString();
                txtDesig.Text = br.ReadString();
                txtSalary.Text = br.ReadInt64().ToString();
                txtDept.Text = br.ReadString();
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

        private void txtEmpId_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
