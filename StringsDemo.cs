using System;

namespace StringsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = "i have something to say";
            String str2 = "i don't have anything";
            Console.WriteLine("upper case of string is " + str1.ToUpper());
            str1 = str1.Remove(12);
            Console.WriteLine("after removing string after 12 index "+str1);
            Console.WriteLine("index of have in string2 " + str2.IndexOf("have"));
        }
    }
}
