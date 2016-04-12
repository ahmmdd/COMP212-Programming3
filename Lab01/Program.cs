/* 1.	
 * Develop a console application by implementing a multicast delegate that 
 * multi-casts four methods: Add, Subtract, Divide, and Multiply. These methods
 * add, subtract, multiply, and divide passes two double numbers to the methods
 * as they are entered by the user from the keyboard. These methods also 
 * display the result of the respective operations. The user may continuously 
 * enter two double numbers using the keyboard or may choose to quit at any time
 * by entering -1 when prompted to enter the first double number.  
 * 
 * The application would call a delegate that multi-casts all the four methods 
 * and pass the two numbers to it.  This single multicast delegate call would 
 * display the results of the addition, subtraction, multiplication, and 
 * division operations on the numbers passed to it.  Please follow the following
 * instructions to develop the application:
 * 
 * • Declare a global delegate type named CalculateDel. CalculateDel would 
 *   represent all void methods that take two double numbers as parameters. 
 *   
 * • Inside the class, create four methods with their respective implementations:
 *   Add, Subtract, Multiply, and Divide that have the same signature as the 
 *   delegate that you have declared. The method Add adds the two numbers that are
 *   passed to and displays the result.  The method Subtract subtracts the second 
 *   number from the first and displays the result.  The method Multiply multiplies 
 *   the two numbers and displays the result. The method Divide divides the first 
 *   number by the second and displays the result. If the second number is a zero 
 *   then it generates an appropriate Data Input Error message. 
 *   
 * • In the Main() declare four CalculateDel objects named addDel, subDel, multDel,
 *   divDel and point them to Add, Subtract, Multiply, and Divide methods that you 
 *   have already created. 
 *   
 * • Create another CalculateDel object named multiCastDel that multicasts all the 
 *   four delegate objects (addDel, subDel, multDel, divDel).
 * 
 * • Write codes to prompt the user to enter the first number and the second number
 *   continuously and pass the input entered by the user to the multiCastDel to 
 *   display results of all the operations in one shot. Let the process continue 
 *   till the user enters -1 as the first number in which case the application would 
 *   terminate with a proper message. 
 * 
 * Name: Mohammed Juned Ahmed
 * Student ID: 300833356
 */
using System;
using System.IO;

namespace Lab01Q1
{
    #region Declaration
    // Declaration +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
    public delegate void CalculateDel(double num1, double num2);
    #endregion
    class Program{
        static double total;
        #region Instantiation
        // Instantiation  ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        public static void addDel(double num1,double num2){
            total = num1 + num2;
            Console.Write("\nThe Result of addition {1} + {2} is: {0}.\n", total, num1, num2);
        }
        public static void subDel(double num1, double num2){
            total = num1 - num2;
            Console.Write("\nThe Result of substraction {1} - {2} is: {0}.\n", total, num1, num2);
        }
        public static void multDel(double num1, double num2){
            total = num1 * num2;
            Console.Write("\nThe Result of multiplicaton {1} * {2} is: {0}.\n", total, num1, num2);
        }
        public static void divDel(double num1, double num2) {
            if (num2 == 0) {
                Console.WriteLine("Data Input Error!!! Can not divide by zero.");
            } else {
                total = num1 / num2;
                Console.Write("\nThe Result of division {1} / {2} is: {0}.\n", total, num1, num2);
            }
        }
        #endregion
        #region Print Messages
        public static void WelcomeMessage()
        {
            Console.WriteLine("\nWelcome to Centennial College Multicast Delegate Application.");
        }
        public static void FirstInputMessage(){
            Console.Write("\nPlease enter the first double number, -1 to quit: ");
        }
        public static void SecondInputMessage()
        {
            Console.Write("\nPlease enter the second double number: ");
        }
        public static void QuitMessage(){
            Console.WriteLine("\nYou have decided to quit the Centennial College Multicast Delegate Application .....\n\nBye for now .....");
        }
        #endregion
        #region Main
        public static void Main(string[] args) {
            double num1, num2;
            WelcomeMessage();
            FirstInputMessage();
            num1 = Convert.ToDouble(Console.ReadLine());
            if (num1 == -1) {
                QuitMessage();
            } else {
                SecondInputMessage();
                num2 = Convert.ToDouble(Console.ReadLine());
                while (true){
                    // Creating & Invoking Delegate Instances ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
                    //Muticasting all 4 delegates objects
                    CalculateDel myCalculateDel = null;
                    myCalculateDel = myCalculateDel + addDel + subDel + multDel + divDel;
                    myCalculateDel(num1, num2);
                    
                    FirstInputMessage();
                    num1 = Convert.ToDouble(Console.ReadLine());
                    if (num1 == -1) {
                        QuitMessage();
                        break;
                    }//End if
                    SecondInputMessage();
                    num2 = Convert.ToDouble(Console.ReadLine());
                }//End While
            }//End else
            Console.Read();
        }//End Main
    #endregion
    }//End Class
}//End Namespace
