using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W03_HashTable{
    class Program{
        private static Hashtable GetHashTable(){

            throw new NotImplementedException();
        }
        static void Main(string[] args){
            Hashtable hashTable = GetHashTable();
            Console.WriteLine(hashTable.ContainsKey("Syed"));

            int value = (int)hashTable["Area"];
            Console.WriteLine(value);

            Console.ReadKey();
        }
    }
}
