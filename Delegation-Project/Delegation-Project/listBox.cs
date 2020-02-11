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
    public partial class Sports : Form
    {
        public Sports()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnOK2_Click(object sender, EventArgs e)
        {
            String games = "";
            if (chkSoccer.Checked==true )
            {
                games += " Play soccer "; // + "in" + radioMississauga.Text);
                //MessageBox.Show(games);
            }
           
            if (chkFootball.Checked ==true)
            {
                games += " & Play football ";
                //MessageBox.Show(games);
            }
            
            if (chkBasketball.Checked == true)
            {
                games += " & Play basketball ";
                
            }
            //location selection from the radio button
            if(radioToronto.Checked)
            {
                games += "in Toronto";
            }
            if (radioBrampton.Checked)
            {
                games += "in Brampton";
            }
            if (radioMississauga.Checked)
            {
                games += "in Mississauga";
            }
            //printing result
            MessageBox.Show(games);

        }
    }
}
