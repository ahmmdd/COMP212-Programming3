using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab02Form{
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        public Dictionary<int, string> students = new Dictionary<int, string>();

        public string FirstName { get; set; }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e) {
            if (textBox1.Text == "" || textBox2.Text == "") {
                MessageBox.Show("Please enter valid values");
            } else {
                if (students.ContainsKey(Convert.ToInt32(textBox1.Text))) {
                    MessageBox.Show("Student already exists");
                    textBox1.Text = null;
                    textBox2.Text = null;
                } else {
                    students.Add(Convert.ToInt32(textBox1.Text), textBox2.Text);
                    MessageBox.Show("Added Successfully");
                    textBox1.Text = null;
                    textBox2.Text = null;
                }
            }
        }

        private void button2_Click_1(object sender, EventArgs e) {
            if (textBox1.Text == "") {
                MessageBox.Show("Please enter valid values");
            } else {
                students.Remove(Convert.ToInt32(textBox1.Text));
                textBox1.Text = null;
                textBox2.Text = null;
                MessageBox.Show("Record at " + textBox1.Text + " deleted successfully");
            }
        }

        private void button3_Click(object sender, EventArgs e) {
            students.Clear();
            MessageBox.Show("All record deleted successfully");
        }

        private void button5_Click_1(object sender, EventArgs e) {
            listBox1.Items.Clear();
        }

        private void button7_Click_1(object sender, EventArgs e) {
            this.Close();
        }

        private void button4_Click_1(object sender, EventArgs e) {
            if (textBox1.Text == "") {
                MessageBox.Show("Please enter valid values");
            } else {
                if (students.ContainsKey(Convert.ToInt32(textBox1.Text))) {
                    string test;
                    if (students.TryGetValue(Convert.ToInt32(textBox1.Text), out test)) {
                        MessageBox.Show("The student at " + textBox1.Text + " is " + test);
                    }
                    textBox1.Text = null;
                    textBox2.Text = null;
                } else {
                    MessageBox.Show("Student does not exist");
                    textBox1.Text = null;
                    textBox2.Text = null;
                }
            }
        }

        private void button6_Click_1(object sender, EventArgs e) {
            listBox1.Items.Clear();
            foreach (var pair in students) {
                listBox1.Items.Add(pair.Key);
                listBox1.Items.Add(pair.Value + "\n");
            }
        }
    }
}
