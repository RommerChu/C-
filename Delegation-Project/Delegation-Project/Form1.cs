using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Delegation_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.btnOK.Click += new System.EventHandler(btnOK1_Click);
        }

        private void btnOK1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your name is: " + txtFirstName.Text + " " + txtLastName.Text);
        }

        private void lblFirstName_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {

        }

        private void nameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Name settingsForm = new Name();

            // Show the settings form
            settingsForm.Show();
            settingsForm.BringToFront();

        }

        private void listBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sports settingsForm = new Sports();

            // Show the settings form
            settingsForm.Show();
            settingsForm.BringToFront();
        }
    }
}
