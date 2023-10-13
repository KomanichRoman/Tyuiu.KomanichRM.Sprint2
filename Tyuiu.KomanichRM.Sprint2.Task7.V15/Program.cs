using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KomanichRM.Sprint2.Task7.V15.Lib;

namespace Tyuiu.KomanichRM.Sprint2.Task7.V15
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #2 | Выполнил: Команич Р. М. | АСОиУб-23-3";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                 *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #15                                                             *");
            Console.WriteLine("* Выполнил: Команич Роман Маркович | АСОиУб-23-3                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу на C#, которая запрашивает исходные данные           *");
            Console.WriteLine("* (вещественные значения) и вычисляет, находится ли точка с               *");
            Console.WriteLine("* координатами X,Y в заштрихованной области.                              *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Ведите значение переменной X: ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ведите значение переменной Y: ");
            double y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            bool res = ds.CheckDotInShadedArea(x, y);
            if (res == true)
            {
                Console.WriteLine("Точка, соответствующая введенным координатам, находиться в заштрихованной области");
            }
            else
            {
                Console.WriteLine("Точка, соответствующая введенным координатам, не находиться в заштрихованной области");
            }
            Console.ReadKey();

        }
    }
}
