using Tyuiu.KomarovaMV.Sprint1.Task3.V11.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.Title = "Спринт #1 | Выполнила: Комарова М. В. | АСОиУБ 24-1";
        DataService ds = new DataService();
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт#1                                                                *");
        Console.WriteLine("* Тема: Базовые навыки работы в с#                                        *");
        Console.WriteLine("* Задание #3                                                              *");
        Console.WriteLine("* Вариант #11                                                             *");
        Console.WriteLine("* Выполнила: Комарова Маргарита Васильевна | АСОиУБ 24-1                  *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("*УСЛОВИЕ:                                                                 *");
        Console.WriteLine("*Напишите программу, которая вычисляет площадь треугольника, если известны*");
        Console.WriteLine("*координаты его углов. Ответ округлите до 3 знаков после запятой.         *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("*ИСХОДНЫЕ ДАННЫЕ:                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("*x1 -> -2                                                                 *");
        Console.WriteLine("*y1 -> 5                                                                  *");
        Console.WriteLine("*x2 -> 1                                                                  *");
        Console.WriteLine("*y2 -> 7                                                                  *");
        Console.WriteLine("*x3 -> 5                                                                  *");
        Console.WriteLine("*y3 -> -3                                                                 *");
        Console.WriteLine("*РЕЗУЛЬТАТ:                                                               *");
        Console.WriteLine("***************************************************************************");
        double x1 = -2;
        double y1 = 5;
        double x2 = 1;
        double y2 = 7;
        double x3 = 5;
        double y3 = -3;
        Console.WriteLine(ds.TriangleArea(x1, y1, x2, y2, x3, y3));
        Console.ReadKey();
    }
}