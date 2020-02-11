using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebForm_FirstName_LastName
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            
        }

        private void BtnSubmit_MouseClick(object sender, MouseEventArgs e)
        {
            Console.WriteLine("This is your name: " + txtFirstName.Text + txtLastName.Text);
        }

    }
}
