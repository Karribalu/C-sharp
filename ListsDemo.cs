using System;
using System.Collections.Generic;

namespace ListsDemo
{
    class Program
    {
        
        static void Main(string[] args)
        {

            List<int> numbers = new List<int>() { 20, 30, 40, 50, 100 };
            int length = numbers.Count;
            Console.WriteLine("Length of the list is " + length);
            Console.WriteLine("the elements of list are");
            numbers.ForEach(num => Console.WriteLine(num + " "));
            numbers.Remove(40);
            Console.WriteLine("after removing the 40 from list ");
            numbers.ForEach(num => Console.WriteLine(num + " "));
            Console.WriteLine("index of 50 in List is " + numbers.IndexOf(50));

            Console.WriteLine("is 40 present in list? " + numbers.Contains(40));
            numbers.Insert(3,200);
            Console.WriteLine("after inserting 200 in list");
            numbers.ForEach(num => Console.WriteLine(num + " "));

        }
    }
}
