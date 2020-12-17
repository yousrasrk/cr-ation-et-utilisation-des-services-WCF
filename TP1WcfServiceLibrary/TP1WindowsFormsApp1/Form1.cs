using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP1WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        ServiceReference1.Service1Client cal = new
         ServiceReference1.Service1Client();
        public Form1()
        {
            InitializeComponent();
        }

        private void Btplus_Click(object sender, EventArgs e)
        {
            Txtz.Text = Convert.ToString(cal.WebAdd(int.Parse(Txtx.Text),
            int.Parse(Txty.Text)));

        }

        private void Btsous_Click(object sender, EventArgs e)
        {
            Txtz.Text = Convert.ToString(cal.WebSoustraction(int.Parse(Txtx.Text),
            int.Parse(Txty.Text)));

        }

        private void Btmult_Click(object sender, EventArgs e)
        {
            Txtz.Text = Convert.ToString(cal.WebMultiply(int.Parse(Txtx.Text),
            int.Parse(Txty.Text)));

        }

        private void Btdiv_Click(object sender, EventArgs e)
        {
            Txtz.Text = Convert.ToString(cal.WebDivision(int.Parse(Txtx.Text),
            int.Parse(Txty.Text)));
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
