using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace WindowsFormsApp
{
    public partial class Product1 : Form
    {
        FileStream fs;
        public Product1()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBinaryWrite_Click(object sender, EventArgs e)
        {
            try
            {
                Product pr = new Product();
                pr.id = Convert.ToInt32(txtProductId.Text);
                pr.name = txtProductName.Text;
                pr.price = Convert.ToInt32(txtProductPrice.Text);
                pr.category = txtProductCat.Text;
                fs = new FileStream(@"D:\DemoFolder\ProductInformation", FileMode.Create, FileAccess.Write);
                BinaryFormatter binary = new BinaryFormatter();
                binary.Serialize(fs, pr);
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
                Product pr = new Product();
                fs = new FileStream(@"D:\DemoFolder\ProductInformation", FileMode.Open, FileAccess.Read);
                BinaryFormatter binary = new BinaryFormatter();
                pr = (Product)binary.Deserialize(fs);
                txtProductId.Text = pr.id.ToString();
                txtProductName.Text = pr.name;
                txtProductPrice.Text = pr.price.ToString();
                txtProductCat.Text = pr.category;

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

        private void btnXMLWrite_Click(object sender, EventArgs e)
        {
            try
            {
                Product pr = new Product();
                pr.id = Convert.ToInt32(txtProductId.Text);
                pr.name = txtProductName.Text;
                pr.price = Convert.ToInt32(txtProductPrice.Text);
                pr.category = txtProductCat.Text;
                fs = new FileStream(@"D:\DemoFolder\ProductInformation", FileMode.Create, FileAccess.Write);
                XmlSerializer xml = new XmlSerializer(typeof(Product));
                xml.Serialize(fs, pr);
                MessageBox.Show("Done !! XML Data is inserted");
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

        private void btnXMLRead_Click(object sender, EventArgs e)
        {
            try
            {
                Product pr = new Product();
                fs = new FileStream(@"D:\DemoFolder\ProductInformation", FileMode.Open, FileAccess.Read);
                XmlSerializer xml = new XmlSerializer(typeof(Product));
                pr = (Product)xml.Deserialize(fs);
                txtProductId.Text = pr.id.ToString();
                txtProductName.Text = pr.name;
                txtProductPrice.Text = pr.price.ToString();
                txtProductCat.Text = pr.category;

                xml.Serialize(fs, pr);
                MessageBox.Show("Done !!Book XML Data is redy to read");

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
                Product pr = new Product();
                pr.id = Convert.ToInt32(txtProductId.Text);
                pr.name = txtProductName.Text;
                pr.price = Convert.ToInt32(txtProductPrice.Text);
                pr.category = txtProductCat.Text;
                fs = new FileStream(@"D:\DemoFolder\ProductInformation", FileMode.Create, FileAccess.Write);
                SoapFormatter so = new SoapFormatter();
                so.Serialize(fs, pr);
                MessageBox.Show("Soap Data is inserted");
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
                Product pr = new Product();
                fs = new FileStream(@"D:\DemoFolder\ProductInformation", FileMode.Open, FileAccess.Read);
                SoapFormatter so = new SoapFormatter();
                pr = (Product)so.Deserialize(fs);
                txtProductId.Text = pr.id.ToString();
                txtProductName.Text = pr.name;
                txtProductPrice.Text = pr.price.ToString();
                txtProductCat.Text = pr.category;
                MessageBox.Show("Soap data is redy");

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

        private void btnJSONWrite_Click(object sender, EventArgs e)
        {
            try
            {
                Product pr = new Product();
                pr.id = Convert.ToInt32(txtProductId.Text);
                pr.name = txtProductName.Text;
                pr.price = Convert.ToInt32(txtProductPrice.Text);
                pr.category = txtProductCat.Text;
                fs = new FileStream(@"D:\DemoFolder\ProductInformation Json.txt", FileMode.Create, FileAccess.Write);
                JsonSerializer.Serialize(fs, pr);
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

        private void btnJSONRead_Click(object sender, EventArgs e)
        {
            try
            {
                Product pr = new Product();
                fs = new FileStream(@"D:\DemoFolder\ProductInformation Json.txt", FileMode.Open, FileAccess.Read);
                pr = JsonSerializer.Deserialize<Product>(fs);
                txtProductId.Text = pr.id.ToString();
                txtProductName.Text = pr.name;
                txtProductPrice.Text = pr.price.ToString();
                txtProductCat.Text = pr.category;
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

        private void txtProductId_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
