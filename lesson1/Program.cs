using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//Автор Матюков Евгений
//Программа Анкета

namespace lesson1
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person(); //новый персонаж

            Console.WriteLine("Программа Анкета");

            Console.Write("Введите ваше имя: ");
            person.Name = Console.ReadLine();

            Console.Write("Введите вашу фамилию: ");
            person.Surname = Console.ReadLine();

            Console.Write("Введите ваш возраст: ");
            person.Age = Convert.ToInt32(Console.ReadLine());
            
            Console.Write("Введите ваш рост: ");
            person.Growth = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите ваш вес: ");
            person.Weight = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine("\nИмя: " + person.Name + ", фамилия: " + person.Surname + ", возраст: " + person.Age + ", рост: " + person.Growth + ", вес: " + person.Weight);

            Console.WriteLine("\nИмя: {0}, фамилия: {1}, возраст: {2}, рост: {3}, вес: {4}", person.Name, person.Surname, person.Age, person.Growth, person.Weight);

            Console.ReadKey();
        }


        class Person
        {
            public string Name { get; set; }
            public string Surname { get; set; }
            public int Age { get; set; }
            public double Growth { get; set; }
            public double Weight { get; set; }
       }
    }
}
