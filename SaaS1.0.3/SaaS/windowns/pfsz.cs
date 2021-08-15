using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static SaaS.windowns.Mian;

namespace SaaS.windowns
{
    public partial class pfsz : Form
    {
        public pfsz()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void btn_infoadd_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex==0)
            {
             //   SaaS.windowns.Mian mian = new Mian();
             //   mian.BackColor = Color.Red;
             //// Mian.panel1.BackColor = Color.Red;
             ///
             
                
            }
            else if(comboBox1.SelectedIndex==1)
            {

            }
            else if (comboBox1.SelectedIndex == 2)
            {


            }
            else if (comboBox1.SelectedIndex == 3)
            {

            }
            else if (comboBox1.SelectedIndex ==4)
            {

            }
            else if (comboBox1.SelectedIndex == 5)
            {

            }
        }
    }
}
