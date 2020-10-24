using System;

namespace record_sample
{
    class Program
    {
        static void Main(string[] args)
        {
            var personC1 = new PersonC("yuta1", new DateTime(1987, 8, 8));
            var personC2 = new PersonC("yuta2", new DateTime(1987, 8, 8));
            Console.WriteLine(personC1.Equals(personC2));
            Console.WriteLine(personC1.ToString());

            var personR1 = new PersonR("yuta1", new DateTime(1987, 8, 8));
            var personR2 = new PersonR("yuta2", new DateTime(1987, 8, 8));
            Console.WriteLine(personR1.Equals(personR2));
            Console.WriteLine(personR1.ToString());
        }
    }

    class PersonC
    {
        public PersonC(string name, DateTime birthday) => (Name, Birthday) = (name, birthday);

        public string Name { get; }
        public DateTime Birthday { get; }
    }

    record PersonR
    {
        public PersonR(string name, DateTime birthday) => (Name, Birthday) = (name, birthday);

        public string Name { get; }
        public DateTime Birthday { get; }
    }
}
