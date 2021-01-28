using System;

namespace AbstactClassLesson
{
    abstract class Person  // Абстрактный класс
    {
        public string Name { get; set; }

        public Person(string name)
        {
            Name = name;
        }
        public abstract void Display();   // Абстрактный метод
    }

    class Client : Person
    {
        public int AccountAmount { get; set; }    // сумма на счету

        public Client(string name, int accountAmount)
            : base(name)
        {
            AccountAmount = accountAmount;
        }
        public override void Display()
        {
            Console.WriteLine($"{Name} имеет счет на сумму : {AccountAmount}");
        }
    }

    class Employee : Person
    {
        public string Position { get; set; } // должность

        public Employee(string name, string position)
            : base(name)
        {
            Position = position;
        }
        public override void Display()
        {
            Console.WriteLine($"{Name} : {Position}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client("Nicolas Cage", 1200000);
            Employee employee = new Employee("Rob Nugent", "Операционист");
            client.Display();
            employee.Display();
        }

    }
}
