using System;

namespace Ex1
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; private set; }
        public DateTime Birth {  get; set; }

        public Person (string name, DateTime birth)
        {
            Name = name;
            Birth = birth;
            Age = CalculteAge();
        }

        private int CalculteAge()
        {
            return (DateTime.Now.Subtract(Birth).Days) / 365; // Subtract the actually date with the birth day and return the age
        }
    }
}
