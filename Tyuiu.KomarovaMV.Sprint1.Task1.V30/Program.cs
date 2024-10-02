using Tyuiu.KomarovaMV.Sprint1.Task1.V30.Lib;
internal class Program

{
    private static void Main(string[] args)
    {
        Console.Title = "Спринт #1 | Выполнила: Комарова М. В. | АСОиУБ 24-1";
        DataService ds = new DataService();
        Console.WriteLine("**************************************************************************");
        Console.WriteLine("* Спринт#1                                                               *");
        Console.WriteLine("* Тема: Базовые навыки работы в с#                                       *");
        Console.WriteLine("* Задание #1                                                             *");
        Console.WriteLine("* Вариант #30                                                            *");
        Console.WriteLine("* Выполнила: Комарова Маргарита Васильевна | АСОиУБ 24-1                 *");
        Console.WriteLine("**************************************************************************");
        Console.WriteLine("*УСЛОВИЕ:                                                                *");
        Console.WriteLine("*Написать программу, которая запрашивает у пользователя исходные данные, *");
        Console.WriteLine("*вычисляет результат по формуле (2+x)/2 и печатает его на экране.        *");
        Console.WriteLine("*                                                                        *");
        Console.WriteLine("*ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("**************************************************************************");
        double x;
        Console.WriteLine("Введите значение Х:");
        x=Convert.ToDouble(Console.ReadLine());
        
        Console.WriteLine("**************************************************************************");
        Console.WriteLine("*РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("**************************************************************************");
        Console.WriteLine(ds.Calculate(x));
        Console.ReadKey();
    }
}