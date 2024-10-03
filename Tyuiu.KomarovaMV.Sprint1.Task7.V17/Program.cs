using Tyuiu.KomarovaMV.Sprint1.Task7.V17.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.Title = "Спринт #1 | Выполнила: Комарова М. В. | АСОиУБ 24-1";
        DataService ds = new DataService();
        Console.WriteLine("**************************************************************************");
        Console.WriteLine("* Спринт#1                                                               *");
        Console.WriteLine("* Тема: Базовые навыки работы в с#                                       *");
        Console.WriteLine("* Задание #7                                                             *");
        Console.WriteLine("* Вариант #17                                                            *");
        Console.WriteLine("* Выполнила: Комарова Маргарита Васильевна | АСОиУБ 24-1                 *");
        Console.WriteLine("**************************************************************************");
        Console.WriteLine("*УСЛОВИЕ:                                                                *");
        Console.WriteLine("*Написать программу, которая вычисляет математическое выражение:         *");
        Console.WriteLine("*     1+sin√x^2+1                                                        *");
        Console.WriteLine("*  z=--------------                                                      *");
        Console.WriteLine("*     cos(12*y-4)                                                        *");
        Console.WriteLine("*ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("**************************************************************************");
        Console.WriteLine("Введите знчение х:");
        double x= Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите знчение y:");
        double y = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("**************************************************************************");
        Console.WriteLine("*РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("**************************************************************************");
        Console.WriteLine(ds.Calculate(x,y));
        Console.ReadKey();
    }
}