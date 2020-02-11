using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2_Fields
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            lstSkills.Items.Add(txtSkills.Text);
            //This is to clear after input from field
            txtSkills.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // lstSkills.Items.Remove(txtSkills.Text);
            
            lstSkills.Items.Remove(lstSkills.SelectedItem);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(txtFirstNameBox.Text + " " + txtLastNameBox.Text + "\n" + txtAddressBox.Text + "\n" + txtJobBox.Text);
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void lstSkills_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lstSkills_MouseClick(object sender, MouseEventArgs e)
        {
            //lstSkills.Items.Remove(lstSkills.Text);
           

        }
    }
}
