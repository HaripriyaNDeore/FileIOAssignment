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
    public partial class Book1 : Form
    {
        FileStream fs;
        public Book1()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            lblShowData.Text = ($"Book Id={txtBookId.Text}Book Name={txtBookName.Text}Book Author={txtBookAuthor.Text}Book Price={txtBookPrice.Text}Book Description={txtBookDescription.Text}");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                Book book = new Book();
                fs = new FileStream(@"D:\DemoFolder\BookInfosoap", FileMode.Open, FileAccess.Read);
                SoapFormatter so = new SoapFormatter();
                book = (Book)so.Deserialize(fs);
                txtBookId.Text = book.bid.ToString();
                txtBookName.Text = book.bname;
                txtBookAuthor.Text = book.authorname;
                txtBookPrice.Text = book.price.ToString();
                txtBookDescription.Text = book.bookdetails;
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

        private void btnBinaryWrite_Click(object sender, EventArgs e)
        {
            try
            {
                Book book = new Book();
                book.bid = Convert.ToInt32(txtBookId.Text);
                book.bname = txtBookName.Text;
                book.authorname = txtBookAuthor.Text;
                book.price = Convert.ToInt32(txtBookPrice.Text);
                book.bookdetails = txtBookDescription.Text;
                fs = new FileStream(@"D:\DemoFolder\BookInformation", FileMode.Create, FileAccess.Write);
                BinaryFormatter binary = new BinaryFormatter();
                binary.Serialize(fs, book);
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
                Book book = new Book();
                fs = new FileStream(@"D:\DemoFolder\BookInformation", FileMode.Open, FileAccess.Read);
                BinaryFormatter binary = new BinaryFormatter();
                book = (Book)binary.Deserialize(fs);
                txtBookId.Text = book.bid.ToString();
                txtBookName.Text = book.bname;
                txtBookAuthor.Text = book.authorname;
                txtBookPrice.Text = book.price.ToString();
                txtBookDescription.Text = book.bookdetails;

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
                Book book = new Book();
                book.bid = Convert.ToInt32(txtBookId.Text);
                book.bname = txtBookName.Text;
                book.authorname = txtBookAuthor.Text;
                book.price = Convert.ToInt32(txtBookPrice.Text);
                book.bookdetails = txtBookDescription.Text;
                fs = new FileStream(@"D:\DemoFolder\BookInformationxml", FileMode.Create, FileAccess.Write);
                XmlSerializer xml = new XmlSerializer(typeof(Book));
                xml.Serialize(fs,book);
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
                Book book = new Book();
                fs = new FileStream(@"D:\DemoFolder\BookInformationxml", FileMode.Open, FileAccess.Read);
                XmlSerializer xml = new XmlSerializer(typeof(Book));
                book = (Book)xml.Deserialize(fs);
                txtBookId.Text = book.bid.ToString();
                txtBookName.Text = book.bname;
                txtBookAuthor.Text = book.authorname;
                txtBookPrice.Text = book.price.ToString();
                txtBookDescription.Text = book.bookdetails;

                xml.Serialize(fs, book);
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

        private void btnSOAPWrite_Click(object sender, EventArgs e)
        {
            try
            {
                Book book = new Book();
                book.bid = Convert.ToInt32(txtBookId.Text);
                book.bname = txtBookName.Text;
                book.authorname = txtBookAuthor.Text;
                book.price = Convert.ToInt32(txtBookPrice.Text);
                book.bookdetails = txtBookDescription.Text;
                fs = new FileStream(@"D:\DemoFolder\BookInfosoap", FileMode.Create, FileAccess.Write);
                SoapFormatter so = new SoapFormatter();
                so.Serialize(fs, book);
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

        private void btnJSONWrite_Click(object sender, EventArgs e)
        {
            try
            {
                Book book = new Book();
                book.bid = Convert.ToInt32(txtBookId.Text);
                book.bname = txtBookName.Text;
                book.authorname = txtBookAuthor.Text;
                book.price = Convert.ToInt32(txtBookPrice.Text);
                book.bookdetails = txtBookDescription.Text;
                fs = new FileStream(@"D:\DemoFolder\Dept Json.txt", FileMode.Create, FileAccess.Write);
                JsonSerializer.Serialize(fs, book);
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
                Book book = new Book();
                fs = new FileStream(@"D:\DemoFolder\Dept Json.txt", FileMode.Open, FileAccess.Read);
                book = JsonSerializer.Deserialize<Book>(fs);
                txtBookId.Text = book.bid.ToString();
                txtBookName.Text = book.bname;
                txtBookAuthor.Text = book.authorname;
                txtBookPrice.Text = book.price.ToString();
                txtBookDescription.Text = book.bookdetails;
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
