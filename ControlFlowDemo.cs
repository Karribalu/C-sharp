using System;

namespace ControlFlowDemo
{
    class Program
    {
        public static void ifDemo()
        {
            int a = 5;
            int b = 20;
            if (a < b)
                Console.WriteLine(a + " is lesser than " + b);
        }
        public static void ifElseDemo()
        {
            int a = 25;
            int b = 5;
            if (a > b)
                Console.WriteLine(a + " is larger");
            else
                Console.WriteLine(b + " is larger");
        }
        public static void ifElseIfDemo()
        {
            int a = 20;
            if (a == 5)
                Console.WriteLine("a is 5");
            else if (a == 10)
                Console.WriteLine("a is 10");
            else if (a == 20)
                Console.WriteLine("a is 20");
        }
        public static void switchDemo()
        {
            int a = 3;
            switch(a)
                {
                case 1:Console.Write("the day is sunday");break;
                case 2: Console.Write("the day is monday"); break;
                case 3: Console.Write("the day is tuesday"); break;
                case 4: Console.Write("the day is wednesday"); break;

                case 5: Console.Write("the day is thursday"); break;
                case 6: Console.Write("the day is friday"); break;
                case 7: Console.Write("the day is saturday"); break;
            }
        }
        static void Main(string[] args)
        {
            ifDemo();
            ifElseDemo();
            ifElseIfDemo();
            switchDemo();
        }
    }
}
