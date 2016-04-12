using System;

namespace W01_Practice2{
    //declaration
    public delegate int NumberChanger(int n);
    class Program{
        static int num = 10;
        #region AddNum
        public static int AddNum(int p){
            num += p;
            return num;
        }
        #endregion
        #region MultipleNum
        public static int MultipleNum(int p){
            num *= p;
            return num;
        }
        #endregion
        #region getNum
        private static int getNum(){
            return num;
        }
        #endregion
        #region Main
        public static void Main(string[] args){
            //create delegate instances
            NumberChanger nc1 = new NumberChanger(AddNum);
            NumberChanger nc2 = MultipleNum;
            //invoking
            nc1(25);
            //display
            Console.WriteLine("The value of Add Num is: {0}", getNum());

            //invoking
            nc2(5);
            //display
            Console.WriteLine("The value of Multiply Num is: {0}", getNum());
            Console.Read();
        }
        #endregion
    }
}
