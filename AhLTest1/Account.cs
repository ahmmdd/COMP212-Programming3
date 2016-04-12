using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AhLTest1
{
    class Account
    {
            private string firstName;
            private string lastName;
            private double balance;
          Dictionary<int, string> MOCustomers = new Dictionary<int, string>(){
                {1234,"John"},
                {5678, "John1"},
                {9101, "John2"},
                {1121, "John3"}
        };
            public Account(string firstName, string lastName, double balance)
            {
                this.firstName = firstName;
                this.lastName = lastName;
                this.balance = balance;

            
        }
    }
}
