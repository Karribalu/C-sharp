using System;
using System.Collections.Generic;

namespace ListExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> integers = new List<int>() { 1, 4, 5, 7, 8, 9, 43, 23, 2, 1, 1, 43 };
            List<int> oplist = new List<int>();
            for(int i = 0; i < integers.Count;i++)
            {
                if (!oplist.Contains(integers[i]))
                    oplist.Add(integers[i]);
            }
            oplist.ForEach(num => Console.Write(num + " "));
        }
    }
}
