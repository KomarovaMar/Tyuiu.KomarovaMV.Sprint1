using Tyuiu.KomarovaMV.Sprint1.Task5.V7.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.Title = "Спринт #1 | Выполнила: Комарова М. В. | АСОиУБ 24-1";
        DataService ds = new DataService();
        Console.WriteLine("**************************************************************************");
        Console.WriteLine("* Спринт#1                                                               *");
        Console.WriteLine("* Тема: Базовые навыки работы в с#                                       *");
        Console.WriteLine("* Задание #5                                                             *");
        Console.WriteLine("* Вариант #7                                                             *");
        Console.WriteLine("* Выполнила: Комарова Маргарита Васильевна | АСОиУБ 24-1                 *");
        Console.WriteLine("**************************************************************************");
        Console.WriteLine("*УСЛОВИЕ:                                                                *");
        Console.WriteLine("*Написать программу, которая решает следующую задачу:                    *");
        Console.WriteLine("*Определить h – полное количество часов прошедших от начала суток до того*");
        Console.WriteLine("*                                                                        *");
        Console.WriteLine("*момента(в первой половине дня), когда часовая стрелка повернулась на f  *");
        Console.WriteLine("*градусов(0 < f < 360, f – вещественное число).                          *");
        Console.WriteLine("*ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("**************************************************************************");
        Console.WriteLine("Введите значение f:");
        double f=Convert.ToDouble(Console.ReadLine());
        int res=ds.AngleToHoursMinutes(f);
        Console.WriteLine("**************************************************************************");
        Console.WriteLine("*РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("**************************************************************************");
        Console.WriteLine(res);
        Console.ReadKey();
    }
}