using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//Автор Матюков Евгений
//Программа выводит на экран моё имя, фамилию и город проживания.

namespace MyPerson
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Евгений", "Матюков", "Нижний Новгород");
            person.Print(10, 10);
            Console.ReadKey();
        }
    }

    class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string City { get; set; }

        public Person (string Name, string Surname, string City)
        {
            this.Name = Name;
            this.Surname = Surname;
            this.City = City; 
        }

        public void Print(int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(Name + " " + Surname + ", " + City);
        }
    }

}
