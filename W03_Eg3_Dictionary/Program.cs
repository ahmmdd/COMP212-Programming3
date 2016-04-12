using System;
using System.Collections.Generic;

namespace W03_Eg3_Dictionary{
    class Program{
        static void Main(string[] args){
            //defined as a data structure
            Dictionary<string, int> dic = new Dictionary<string, int>(){
                {"cat", 2},
                {"dog", 1},
                {"fish", 0}
            };
            foreach (KeyValuePair<string, int> pair in dic){
                Console.WriteLine("{0}, {1}", pair.Key, pair.Value);
            }
            Console.WriteLine();
            foreach (var pair in dic){
                Console.WriteLine("{0}, {1}", pair.Key, pair.Value);
            }
            Console.ReadKey();
        }
    }
}
