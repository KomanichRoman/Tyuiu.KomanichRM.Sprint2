using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KomanichRM.Sprint2.Task5.V9.Lib;

namespace Tyuiu.KomanichRM.Sprint2.Task5.V9
{
    class Program
    {
        static void Main(string[] args)
        {

            DataService ds = new DataService();
            Console.Title = "Спринт #2 | Выполнил: Команич Р. М. | АСОиУб-23-3";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Оператор switch                                                   *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #9                                                              *");
            Console.WriteLine("* Выполнил: Команич Роман Маркович | АСОиУб-23-3                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая использует оператор switch вычисляет        *");
            Console.WriteLine("* требуемое значение и возвращает результат.                              *");
            Console.WriteLine("* Условие: Дата некоторого дня характеризуется двумя натуральными         *");
            Console.WriteLine("* числами: m (порядковый номер месяца) и n (число).                       *");
            Console.WriteLine("* По заданным n и m определить дату следующего дня                        *");
            Console.WriteLine("* (принять, что n и m не характеризуют 31 декабря).                       *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите номер месяца: ");
            int numMounth = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите номер дня: ");
            int numDay = Convert.ToInt32(Console.ReadLine());

            string res;


            if ((((numMounth < 1) || (numMounth > 12)) && ((numDay < 1) || (numDay > 30))) && ((numMounth == 4) || (numMounth == 9) || (numMounth == 6) || (numMounth == 11)))
            {
                res = "Введено неверное значение!";
            }
            else
            {
                res = ds.FindDateOfNextDay(numMounth);
            }

            if ((((numMounth < 1) || (numMounth > 12)) && ((numDay < 1) || (numDay > 31))) && ((numMounth == 1) || (numMounth == 2) || (numMounth == 5) || (numMounth == 11) || (numMounth == 7) || (numMounth == 8) || (numMounth == 10) || (numMounth == 12)))
            {
                res = "Введено неверное значение!";
            }
            else
            {
                res = ds.FindDateOfNextDay(numMounth);
            }

            if ((((numMounth < 1) || (numMounth > 12)) && ((numDay < 1) || (numDay > 28))) && (numMounth == 2))
            {
                res = "Введено неверное значение!";
            }
            else
            {
                res = ds.FindDateOfNextDay(numMounth);
            }
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Дата следующего дня= Месяц: " + ds.FindDateOfNextDay(numMounth) + " День: " + (numDay+1));
            Console.ReadKey();


        }
    }
}
