using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace W05TabControl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radBlue_CheckedChanged(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Blue;
        }

        private void radRed_CheckedChanged(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Red;
        }

        private void radMsgHi_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = "Hi";
        }

        private void radMsgBye_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = "Bye";
        }

        private void radSize12_CheckedChanged(object sender, EventArgs e)
        {
            label1.Font = new Font(label1.Font.Name, 12);
        }

        private void radSize14_CheckedChanged(object sender, EventArgs e)
        {
            label1.Font = new Font(label1.Font.Name, 14);
        }
    }
}
