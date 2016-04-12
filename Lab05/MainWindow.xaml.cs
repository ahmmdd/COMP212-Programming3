using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Lab05{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
    class Account{
        double balance;
        double deposit(double sum){
            
        }
        double withdraw(double sum){
            if (sum > balance){
                balance -= 5;
                return -5; // this will come in handy in Prob. 6 
            }else{
                balance -= sum;
                return balance; // Notice: always >= 0 (never < 0)
            }
        }
        double inquire() { return balance; }
        Account() { balance = 0; }
        Account(double sum) { balance = sum; }
        double interest(double rate){
            return rate * balance;
        }
    }
    
    public partial class MainWindow : Window{
        public MainWindow(){
            InitializeComponent();
        }
        public static int balance = 1000;
        public void deposit(double amount, String account)
        {
            
            if (account.Equals(radCheckingAccount)) {
                balance += Convert.ToInt32(txtAmount);
                
            }
                
            else if(account.Equals(radSavingAccount)){
                balance += Convert.ToInt32(txtAmount);
            } 
        }
        public void withdraw(double amount, String account)
        {
            if (account.Equals(radCheckingAccount))
            {
                balance -= Convert.ToInt32(txtAmount);

            }

            else if (account.Equals(radSavingAccount))
            {
                balance -= Convert.ToInt32(txtAmount);
            } 
        }
        private void Add(object sender, RoutedEventArgs e) {
            

        }
    }
}
