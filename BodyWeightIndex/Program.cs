using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//Автор Матюков Евгений
//Программа Индекс массы тела

namespace BodyWeightIndex
{
    class Program
    {
        static void Main(string[] args)
        {
            double bwindex, growth, weight; 

            Console.WriteLine("Программа Индекс массы тела");

            Console.Write("Введите ваш рост в см: ");
            growth = Convert.ToDouble(Console.ReadLine()) / 100;

            Console.Write("Введите ваш вес в кг: ");
            weight = Convert.ToDouble(Console.ReadLine());

            bwindex = weight / (growth * growth);

            Console.Write("\nВаш индекс: {0:F1}", bwindex);

            Console.ReadKey();
        }
    }
}
