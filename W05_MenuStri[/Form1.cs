using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace W05_MenuStrip
{
    public partial class Form1 : Form {
        public Form1(){ InitializeComponent(); }

        private void ClearColor(){
            blackToolStripMenuItem.Checked = false;
            redToolStripMenuItem.Checked = false;
            blueToolStripMenuItem.Checked = false;
            greenToolStripMenuItem.Checked = false;
        }
        private void ClearFont(){
            timesNewRomanToolStripMenuItem.Checked = false;
            arialToolStripMenuItem.Checked = false;
            courierToolStripMenuItem.Checked = false;
        }
        private void aboutUsToolStripMenuItem_Click(object sender, EventArgs e){
            MessageBox.Show("This is intended to give students a good lesson", "About Us", MessageBoxButtons.YesNoCancel);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e) { Application.Exit(); }

        private void blackToolStripMenuItem_Click(object sender, EventArgs e){
            // Reset the check marks for black
            ClearColor();
            // Set the color to black
            label1.ForeColor = Color.Black;
            // check the selected color to true
            blackToolStripMenuItem.Checked = true;
        }

        private void redToolStripMenuItem_Click(object sender, EventArgs e) {
            // Reset the check marks for red
            ClearColor();
            // Set the color to red
            label1.ForeColor = Color.Red;
            // check the selected color to true
            redToolStripMenuItem.Checked = true;
        }

        private void blueToolStripMenuItem_Click(object sender, EventArgs e) {
            // Reset the check marks for blue
            ClearColor();
            // Set the color to blue
            label1.ForeColor = Color.Blue;
            // check the selected color to true
            blueToolStripMenuItem.Checked = true;
        }

        private void greenToolStripMenuItem_Click(object sender, EventArgs e) {
            // Reset the check marks for green
            ClearColor();
            // Set the color to green
            label1.ForeColor = Color.Green;
            // check the selected color to true
            greenToolStripMenuItem.Checked = true;
        }

        private void timesNewRomanToolStripMenuItem_Click(object sender, EventArgs e) {
            ClearFont();
            label1.Font = new Font("Times New Roman", 14, label1.Font.Style);
            timesNewRomanToolStripMenuItem.Checked = true;
        }

        private void courierToolStripMenuItem_Click(object sender, EventArgs e) {
            ClearFont();
            label1.Font = new Font("Courier", 14, label1.Font.Style);
            courierToolStripMenuItem.Checked = true;
        }

        private void arialToolStripMenuItem_Click(object sender, EventArgs e) {
            ClearFont();
            label1.Font = new Font("Arial", 14, label1.Font.Style);
            arialToolStripMenuItem.Checked = true;
        }

        private void boldToolStripMenuItem_Click(object sender, EventArgs e) {
            //routine for toggle 
            boldToolStripMenuItem.Checked = !boldToolStripMenuItem.Checked;
            //use XOR to toggle bold, keeping all other styles intact
            label1.Font = new Font(label1.Font, label1.Font.Style ^ FontStyle.Bold);
        }

        private void itlaicToolStripMenuItem_Click(object sender, EventArgs e){
            itlaicToolStripMenuItem.Checked = !itlaicToolStripMenuItem.Checked;
            label1.Font = new Font(label1.Font, label1.Font.Style ^ FontStyle.Italic);
        }

        private void underLineToolStripMenuItem_Click(object sender, EventArgs e) {
            underLineToolStripMenuItem.Checked = !underLineToolStripMenuItem.Checked;
            label1.Font = new Font(label1.Font, label1.Font.Style ^ FontStyle.Underline);
        }
    }
}
