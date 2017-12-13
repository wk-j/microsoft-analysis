using System;

namespace Hello
{
    class Person
    {
        public int Age { set; get; }
    }

    // This class violates the rule.
    public class UseReadOnly
    {
        static readonly int x = 3;
        static readonly double y = x + 2.1;
        static readonly string s = "readonly";
    }


    class Program
    {
        static string s;
        static void Main(string[] args)
        {
            string k = "k";
            Console.WriteLine(s);
            Console.WriteLine("Hello World!");

            var p = new Person();
            p.Age = 0b10100;
        }
    }
}
