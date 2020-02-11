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
    public partial class Name : Form
    {
        public Name()
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

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblLastName_Click(object sender, EventArgs e)
        {

        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnOK_Click(object sender, EventArgs e)
        {

        }
    }
}
