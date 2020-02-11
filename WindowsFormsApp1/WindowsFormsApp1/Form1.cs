using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello" + " " + txtFullName.Text + "!");
           

        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void txtFullName_MouseHover(object sender, EventArgs e)
        {
            MessageBox.Show("Not Allowed");
        }

        private void txtFullName_KeyDown(object sender, KeyEventArgs e)
        {
            MessageBox.Show(" Key Pressed is "+e.KeyValue);
        }

        private void txtFullName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
