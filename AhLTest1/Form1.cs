using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AhLTest1
{
    
    public partial class Form1 : Form
    {
        Account firstName;
        Account LastName;
        Account balance;
        Account MOCustomer;
        public Form1()
        {
            InitializeComponent();
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void txtAccountNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void tsSearch_Click(object sender, EventArgs e)
        {
       
        }

        private void tsExit_Click(object sender, EventArgs e)
        { Application.Exit(); }

        private void btnExit_Click(object sender, EventArgs e)
        { Application.Exit(); }

        private void btnViewAllAccounts_Click(object sender, EventArgs e)
        {
            Dictionary<int, string> MOCustomers = new Dictionary<int, string>(){
                {1234,"John"},
                {5678, "John1"},
                {9101, "John2"},
                {1121, "John3"}
        };
            
           foreach (KeyValuePair<int, Account> pair in MOCustomers)
            {
                Console.WriteLine("Account Number:{0} First Name: {1}", pair.Key, pair.Value);
            }
            Console.WriteLine();
        }

    }
}
