using System;

namespace Calculator1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var calculator = new MyCalculator(); //defult has an empty constructor that creates the blank object
            //calculator.Add("hello", "5");


            Console.ReadKey();
        }
    }
}
