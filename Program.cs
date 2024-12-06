using System;

namespace VirtualMethodsExample
{
    // Базовий клас
    class BaseClass
    {
        public virtual void DisplayInfo()
        {
            Console.WriteLine("Це метод базового класу.");
        }
    }

    // Похідний клас 1
    class DerivedClass1 : BaseClass
    {
        public override void DisplayInfo()
        {
            Console.WriteLine("Це метод похідного класу 1.");
        }
    }

    // Похідний клас 2
    class DerivedClass2 : BaseClass
    {
        public override void DisplayInfo()
        {
            Console.WriteLine("Це метод похідного класу 2.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Оберіть режим роботи (1 або 2):");
            string userChoice = Console.ReadLine();

            BaseClass obj;

            if (userChoice == "1")
            {
                obj = new DerivedClass1();
            }
            else
            {
                obj = new DerivedClass2();
            }

            // Виклик віртуального методу через вказівник на базовий клас
            obj.DisplayInfo();

            Console.WriteLine("Змінюємо методи на звичайні для перевірки.");
        }
    }
}
