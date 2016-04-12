using System;

namespace W01_Practice1{

    //declaration
    public delegate void SimpleDelegate();
    class Program{
        //Instantiation 
        public static void myTesting(){
            Console.WriteLine("\nI was called via Delegate.");
        }

        public static void Main(string[] args){
            //create delegate instances
            //SimpleDelegate mySimpleDelegate = new SimpleDelegate(myTesting);
            SimpleDelegate mySimpleDelegate = myTesting;
            //invoking
            mySimpleDelegate();
            Console.Read();
        }
    }
}
