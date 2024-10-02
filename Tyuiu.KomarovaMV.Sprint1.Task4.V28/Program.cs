using Tyuiu.KomarovaMV.Sprint1.Task4.V28.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.Title = "Спринт #1 | Выполнила: Комарова М. В. | АСОиУБ 24-1";
        DataService ds = new DataService();
        Console.WriteLine("**************************************************************************");
        Console.WriteLine("* Спринт#1                                                               *");
        Console.WriteLine("* Тема: Базовые навыки работы в с#                                       *");
        Console.WriteLine("* Задание #4                                                             *");
        Console.WriteLine("* Вариант #28                                                            *");
        Console.WriteLine("* Выполнила: Комарова Маргарита Васильевна | АСОиУБ 24-1                 *");
        Console.WriteLine("**************************************************************************");
        Console.WriteLine("*УСЛОВИЕ:                                                                *");
        Console.WriteLine("*Написать программу, которая запрашивает у пользователя исходные данные  *");
        Console.WriteLine("*вычисляет результат по формуле и печатает его на экране                 *");
        Console.WriteLine("*                                                                        *");
        Console.WriteLine("*ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("**************************************************************************");
        int x;
        int y;
        Console.WriteLine("Введите значение Х:");
        x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите значение Х:");
        y = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("**************************************************************************");
        Console.WriteLine("*РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("**************************************************************************");
        Console.WriteLine(ds.Calculate(x,y));
        Console.ReadKey();
    }
}