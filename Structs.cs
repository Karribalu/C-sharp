using System;

namespace Structs
{
    class Program
    {
        struct Student
        {
            public string name;
            public int age;
        }

        static void Main(string[] args)
        {
            
         Student St1;
         St1.name = "balu";
          St1.age = 19;
            Console.WriteLine($"name is {St1.name} and Age is {St1.age}");

        }
    }
}
