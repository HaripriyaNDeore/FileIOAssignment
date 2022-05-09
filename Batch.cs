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

namespace WindowsFormsApp
{
    public partial class Batch : Form
    {
        FileStream fs;
        public Batch()
        {
            InitializeComponent();
        }

        private void btnBinaryWrite_Click(object sender, EventArgs e)
        {
            try
            {
                Store st = new Store();
                st.batchid = Convert.ToInt32(txtBatchId.Text);
                st.batchname = txtBatchName.Text;
                st.startdate = Convert.ToDateTime(txtStartDate.Text);
                st.enddate = Convert.ToDateTime(txtEndDate.Text);
                st.location = txtLocation.Text;
                st.trainername = txtTrainerName.Text;
               
                fs = new FileStream(@"D:\DemoFolder\BatchInformation", FileMode.Create, FileAccess.Write);
                BinaryFormatter binary = new BinaryFormatter();
                binary.Serialize(fs, st);
                MessageBox.Show("Done!! Batch Information inserted successfully");
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
                Store st = new Store();
                fs = new FileStream(@"D:\DemoFolder\BatchInformation", FileMode.Open, FileAccess.Read);
                BinaryFormatter binary = new BinaryFormatter();
                st = (Store)binary.Deserialize(fs);
                txtBatchId.Text = st.batchid.ToString();
                txtBatchName.Text = st.batchname;
                txtStartDate.Text = st.startdate.ToString();

                txtEndDate.Text = st.enddate.ToString();
                txtLocation.Text = st.location;
                txtTrainerName.Text = st.trainername;
                MessageBox.Show("Done!! Batch Information is ready to read");

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

        private void btnShowData_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Batch Id:{txtBatchId.Text} Batch Name:{txtBatchName.Text}Batch Start Date:{txtStartDate.Text}Batch End Date:{txtEndDate.Text}Batch Location:{txtLocation.Text}Batch Trainer Name:{txtTrainerName.Text}");
        }

        private void txtBatchId_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
