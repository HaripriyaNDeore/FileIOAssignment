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
    public partial class Deparment : Form
    {
        FileStream fs;
        public Deparment()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCreateFolder_Click(object sender, EventArgs e)
        {
            try
            {
                String path = @"D:\DemoFolder";
                if(Directory.Exists(path))
                {
                    MessageBox.Show("Folder Already Exist");
                }
                else
                {
                    Directory.CreateDirectory(path);
                    MessageBox.Show("Folder Created");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCreateFile_Click(object sender, EventArgs e)
        {
            try
            {
                String path = @"D:\DemoFolder\FirstFile.txt";
                if (File.Exists(path))
                {
                    MessageBox.Show("Folder Already Exist");
                }
                else
                {
                    File.Create(path);
                    MessageBox.Show("Folder Created");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnWrToFi_Click(object sender, EventArgs e)
        {
            
            try
            {
                int id = Convert.ToInt32(txtbDeptId.Text);
                String name = txtbDeptNm.Text;
                String location = txtbDeptLoc.Text;
                fs = new FileStream(@"D:\DemoFolder\FirstFile.txt", FileMode.Create, FileAccess.Write);
                BinaryWriter bw = new BinaryWriter(fs);
                bw.Write(id);
                bw.Write(name);
                bw.Write(location);
                bw.Close();
                MessageBox.Show("Done!!! Record inserted");
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

        private void txtbDeptLoc_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnReadFromFile_Click(object sender, EventArgs e)
        {
            try
            {
               /* int id = Convert.ToInt32(txtbDeptId.Text);
                String name = txtbDeptNm.Text;
                String location = txtbDeptLoc.Text;*/
                fs = new FileStream(@"D:\DemoFolder\FirstFile.txt", FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                txtbDeptId.Text = br.ReadInt32().ToString();
                txtbDeptNm.Text = br.ReadString();
                txtbDeptLoc.Text = br.ReadString();
                

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

        private void txtbDeptId_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
