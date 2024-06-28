using System;
using System.Collections.Generic;

namespace Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insert how many people you want to register: ");
            int qtt = int.Parse(Console.ReadLine());

            List<Person> people = new List<Person>();

            for (int i = 1; i <= qtt; i++)
            {
                Console.WriteLine("Person 1:");
                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Birth (dd/MM/yyyy): ");
                string birthString = Console.ReadLine();

                string[] birthSplit = string.IsNullOrEmpty(birthString) ? null : birthString.Split('/');

                DateTime birth = new DateTime(int.Parse(birthSplit[2]), int.Parse(birthSplit[1]), int.Parse(birthSplit[0]));

                people.Add(new Person(name, birth));
            }

            Console.WriteLine("People registered:");

            foreach (Person person in people)
            {
                Console.WriteLine(person);
            }
        }
    }
}