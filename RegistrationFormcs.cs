using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class RegistrationFormcs : Form
    {
        public RegistrationFormcs()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Name={txtFName.Text} EmailId={txtEmailId.Text } Contact Number={ txtContactNo.Text } Address={ txtAdd.Text }");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtFName.Clear();
            txtEmailId.Clear();
            txtContactNo.Clear();
            txtAdd.Clear();
        }

        private void RegistrationFormcs_Load(object sender, EventArgs e)
        {

        }

        private void txtFName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEmailId_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblData_Click(object sender, EventArgs e)
        {
            lblshow.Text=($"Name={txtFName.Text} EmailId={txtEmailId.Text } Contact Number={ txtContactNo.Text } Address={ txtAdd.Text }");
        }
    }
}
