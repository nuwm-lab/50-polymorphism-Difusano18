using System;

namespace PolymorphismExample
{
    // Базовий клас
    public class BaseClass
    {
        // Віртуальний метод
        public virtual void DisplayMessage()
        {
            Console.WriteLine("Це повідомлення з базового класу.");
        }
    }

    // Похідний клас 1
    public class DerivedClass1 : BaseClass
    {
        // Перевизначення віртуального методу
        public override void DisplayMessage()
        {
            Console.WriteLine("Це повідомлення з похідного класу 1.");
        }
    }

    // Похідний клас 2
    public class DerivedClass2 : BaseClass
    {
        // Перевизначення віртуального методу
        public override void DisplayMessage()
        {
            Console.WriteLine("Це повідомлення з похідного класу 2.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Масив для зберігання об'єктів
            BaseClass[] objects = new BaseClass[2];

            // Створення об'єктів динамічно
            Console.WriteLine("Створюємо об'єкт 1 (DerivedClass1):");
            objects[0] = new DerivedClass1();

            Console.WriteLine("Створюємо об'єкт 2 (DerivedClass2):");
            objects[1] = new DerivedClass2();

            // Виклик віртуальних методів через базовий клас
            foreach (BaseClass obj in objects)
            {
                obj.DisplayMessage(); // Викликається метод відповідного похідного класу
            }

            Console.WriteLine("Робота програми завершена.");
        }
    }
}
