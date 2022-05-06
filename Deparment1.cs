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
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;
using System.Runtime.Serialization.Formatters.Soap;
using System.Text.Json;

namespace WindowsFormsApp
{
    public partial class Deparment1 : Form
    {
        FileStream fs;
        public Deparment1()
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

        private void btnBinaryWrite_Click(object sender, EventArgs e)
        {
            try
            {
                Deparment dept = new Deparment();
                dept.id = Convert.ToInt32(txtbDeptId.Text);
                dept.name = txtbDeptNm.Text;
                dept.location = txtbDeptLoc.Text;
                fs = new FileStream(@"D:\DemoFolder\Dept", FileMode.Create, FileAccess.Write);
                BinaryFormatter binary = new BinaryFormatter();
                binary.Serialize(fs,dept);
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

        private void btnBinaryRead_Click(object sender, EventArgs e)
        {
            try
            {
                Deparment dept = new Deparment();
                fs = new FileStream(@"D:\DemoFolder\Dept", FileMode.Open, FileAccess.Read);
                BinaryFormatter binary = new BinaryFormatter();
                dept = (Deparment)binary.Deserialize(fs);
                txtbDeptId.Text = dept.id.ToString();
                txtbDeptNm.Text = dept.name;
                txtbDeptLoc.Text = dept.location;

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

        private void btnXmlWrite_Click(object sender, EventArgs e)
        {
            try
            {
                Deparment dept = new Deparment();
                dept.id = Convert.ToInt32(txtbDeptId.Text);
                dept.name = txtbDeptNm.Text;
                dept.location = txtbDeptLoc.Text;
                fs = new FileStream(@"D:\DemoFolder\Deptxml", FileMode.Create, FileAccess.Write);
                XmlSerializer xml = new XmlSerializer(typeof (Deparment));
                xml.Serialize(fs, dept);
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

        private void btnXmlRead_Click(object sender, EventArgs e)
        {
            try
            {
                Deparment dept = new Deparment();
                fs = new FileStream(@"D:\DemoFolder\Deptxml", FileMode.Open, FileAccess.Read);
                XmlSerializer xml = new XmlSerializer(typeof(Deparment));
                dept = (Deparment)xml.Deserialize(fs);
                txtbDeptId.Text = dept.id.ToString();
                txtbDeptNm.Text = dept.name;
                txtbDeptLoc.Text = dept.location;

                xml.Serialize(fs, dept);
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

        private void btnSoapWrite_Click(object sender, EventArgs e)
        {
            try
            {
                Deparment dept = new Deparment();
                dept.id = Convert.ToInt32(txtbDeptId.Text);
                dept.name = txtbDeptNm.Text;
                dept.location = txtbDeptLoc.Text;
                fs = new FileStream(@"D:\DemoFolder\Deptsoap", FileMode.Create, FileAccess.Write);
                SoapFormatter so = new SoapFormatter();
                so.Serialize(fs, dept);
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

        private void btnSoapRead_Click(object sender, EventArgs e)
        {
            try
            {
                Deparment dept = new Deparment();
                fs = new FileStream(@"D:\DemoFolder\Deptsoap", FileMode.Open, FileAccess.Read);
                SoapFormatter so = new SoapFormatter();
                dept = (Deparment)so.Deserialize(fs);
                txtbDeptId.Text = dept.id.ToString();
                txtbDeptNm.Text = dept.name;
                txtbDeptLoc.Text = dept.location;

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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Deparment dept = new Deparment();
                dept.id = Convert.ToInt32(txtbDeptId.Text);
                dept.name = txtbDeptNm.Text;
                dept.location = txtbDeptLoc.Text;
                fs = new FileStream(@"D:\DemoFolder\Dept Json.txt", FileMode.Create, FileAccess.Write);
                JsonSerializer.Serialize(fs,dept);
                MessageBox.Show("Done !! Json Data inserted");
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

        private void btnJsonRead_Click(object sender, EventArgs e)
        {
            try
            {
                Deparment dept = new Deparment();
                fs = new FileStream(@"D:\DemoFolder\Dept Json.txt", FileMode.Open, FileAccess.Read);
                dept = JsonSerializer.Deserialize<Deparment>(fs);
                txtbDeptId.Text = dept.id.ToString();
                txtbDeptNm.Text = dept.name;
                txtbDeptLoc.Text = dept.location;
                MessageBox.Show("Json data is ready");

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
