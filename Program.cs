using System;

namespace PolymorphismExample
{
    // Базовий клас
    public class BaseClass
    {
        // Віртуальний метод
        public virtual void ShowInfo()
        {
            Console.WriteLine("Це метод базового класу.");
        }
    }

    // Похідний клас 1
    public class DerivedClass1 : BaseClass
    {
        // Перевизначення віртуального методу
        public override void ShowInfo()
        {
            Console.WriteLine("Це метод похідного класу 1.");
        }
    }

    // Похідний клас 2
    public class DerivedClass2 : BaseClass
    {
        // Перевизначення віртуального методу
        public override void ShowInfo()
        {
            Console.WriteLine("Це метод похідного класу 2.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Змінна для вибору об'єкта
            Console.WriteLine("Виберіть, який об'єкт створити (1 - DerivedClass1, 2 - DerivedClass2):");
            int userChoose = int.Parse(Console.ReadLine());

            // Змінна для збереження базового класу
            BaseClass obj;

            // Динамічне створення об'єкта залежно від вибору
            if (userChoose == 1)
            {
                obj = new DerivedClass1(); // Створення об'єкта похідного класу 1
                Console.WriteLine("Створено об'єкт DerivedClass1.");
            }
            else
            {
                obj = new DerivedClass2(); // Створення об'єкта похідного класу 2
                Console.WriteLine("Створено об'єкт DerivedClass2.");
            }

            // Виклик віртуального методу через вказівник на базовий клас
            obj.ShowInfo();

            Console.WriteLine("Робота програми завершена.");
        }
    }
}
