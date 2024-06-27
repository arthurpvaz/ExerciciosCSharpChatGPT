using System;

namespace Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person("Arthur", new DateTime(2004, 10, 20));

            Console.WriteLine("Age: " + p1.Age);
        }
    }
}