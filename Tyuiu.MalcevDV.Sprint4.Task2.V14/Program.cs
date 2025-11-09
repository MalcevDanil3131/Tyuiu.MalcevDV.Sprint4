using System.ComponentModel.DataAnnotations;
using Tyuiu.MalcevDV.Sprint4.Task2.V14.Lib;
void PrintCenteredLine(string text, int totalWidth)
{
    var padding = totalWidth - text.Length - 2; // -2 для звездочек по бокам
    Console.WriteLine($"* {text}{new string(' ', padding)}*");
}

var width = 75;

Console.WriteLine(new string('*', width));
PrintCenteredLine("Спринт #4", width);
PrintCenteredLine("Тема: Создание решения по спринту", width);
PrintCenteredLine("Задание #0", width);
PrintCenteredLine("Вариант #22", width);
PrintCenteredLine("Выполнил: Мальцев Данил Вячеславович | РППБ-25-1", width);
Console.WriteLine(new string('*', width));
PrintCenteredLine("УСЛОВИЕ:", width);
PrintCenteredLine("Написать программу, подсчитывающую сумму нечетных элементов массива", width);
Console.WriteLine(new string('*', width));
PrintCenteredLine("ИСХОДНЫЕ ДАННЫЕ:", width);
DataService ds = new DataService();
Random rand = new Random();
int len = 12;
int[] numbers = new int[len];
for (int i = 0; i < len; i++)
{
    numbers[i] = rand.Next(1, 8);
}
for (int i = 0; i < numbers.Length; i++)
{
    Console.Write(numbers[i] + " ");
}
Console.WriteLine();
var res = ds.Calculate(numbers);
Console.WriteLine(new string('*', width));
PrintCenteredLine("РЕЗУЛЬТАТ:", width);
Console.WriteLine(new string('*', width));
PrintCenteredLine($"Сумма нечетных элемнентов: {res}", width);
Console.WriteLine(new string('*', width));