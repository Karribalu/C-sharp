using System;

namespace EnumDemo
{
    class Program
    {
        enum month
        {
            January,    // 0
            February,   // 1
            March,      // 2
            April,      // 3
            May,        // 4
            June,       // 5
            July        // 6
        }
        static void Main(string[] args)
        {
            int mon = (int)month.April;
            Console.WriteLine("April month is "+(mon + 1));
        }
    }
}
