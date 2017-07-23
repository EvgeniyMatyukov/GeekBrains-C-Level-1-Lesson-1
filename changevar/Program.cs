using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//Автор Матюков Евгений
//Программа обмен значений двух переменных без использования третьей переменной

namespace changevar
{
    class Program
    {
        static void ChangeVar (ref int x, ref int y)
        {
            if (x == y) return;
            x ^= y;
            y ^= x;
            x ^= y;
        }

        static void Main(string[] args)
        {
            int x = 2, y = 3;
            Console.WriteLine("Программа меняет местами значения двух переменных, без использования третьей переменной");

            Console.WriteLine("Переменная 1 = {0}, переменная 2 = {1}", x, y);

            Console.WriteLine("Меняем местами");

            ChangeVar(ref x, ref y);

            Console.WriteLine("Переменная 1 = {0}, переменная 2 = {1}", x, y);

            Console.ReadKey();
 

        }
    }
}
