using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace W05ToolStrip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripContainer2_TopToolStripPanel_Click(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.cricket.org");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            while (toolStripProgressBar1.Value < 5)
            {
                toolStripProgressBar1.Value += 5;
            }
        }

        private void toolStripStatusLabel2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("@C:/");
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            toolStripStatusLabel3.Text = "You are on the Save Button";
        }

        private void toolStripStatusLabel3_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel3.Text = "";
        }
    }
}
