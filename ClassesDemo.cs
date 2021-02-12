using System;

namespace ClassesDemo
{
    class color
    {
        public string colour = "red";
        public color(string newcolor)
        {
            colour = newcolor;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            color obj = new color("blue");
   
            Console.WriteLine(obj.colour);
           
        }
    }
}
