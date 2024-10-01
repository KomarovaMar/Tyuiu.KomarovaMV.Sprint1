using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KomarovaMV.Sprint1.Task0.V18.Lib;

namespace Tyuiu.KomarovaMV.Sprint1.Task0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #1 | Выполнила: Комарова М. В. | АСОиУБ 24-1";
            DataService ds = new DataService();
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* Спринт#1                                                             *");
            Console.WriteLine("* Тема: Базовые навыки работы в с#                                       *");
            Console.WriteLine("* Задание #0                                                             *");
            Console.WriteLine("* Вариант #18                                                            *");
            Console.WriteLine("* Выполнила: Комарова Маргарита Васильевна | АСОиУБ 24-1                 *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("*УСЛОВИЕ:                                                                *");
            Console.WriteLine("*Написать программу, которая вычисляет выражение 9*(6/2*3)/9/3           *");
            Console.WriteLine("*и печатает результат на экране.                                         *");
            Console.WriteLine("*                                                                        *");
            Console.WriteLine("*ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("*9*(6/2*3)/9/3                                                           *");
            Console.WriteLine("*РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine(ds.Calculate());
            Console.ReadKey();
        }
    }
}
