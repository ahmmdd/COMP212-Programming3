using System;
using System.Collections.Generic;

namespace W03_Eg2_Dictionary{
    class Program{
        static void Main(string[] args){
            Dictionary<string, string> values = new Dictionary<string, string>();
            values.Add("Syed", "Male");
            values.Add("John", "Male");
            values.Add("Susan", "Female");
            values.Add("Priya", "Female");

            string test1, test2;
            if (values.TryGetValue("Syed", out test1)) {
                Console.WriteLine(test1);

            }
            if (values.TryGetValue("Firdaus", out test2)){
                Console.WriteLine(test2);

            }
            Console.ReadKey();
        }
    }
}
