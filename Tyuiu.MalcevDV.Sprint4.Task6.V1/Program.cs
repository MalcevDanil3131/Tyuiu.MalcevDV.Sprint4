using Tyuiu.MalcevDV.Sprint4.Task6.V1.Lib;
void PrintCenteredLine(string text, int totalWidth)
{
    var padding = totalWidth - text.Length - 2; // -2 для звездочек по бокам
    Console.WriteLine($"* {text}{new string(' ', padding)}*");
}

var width = 75;

Console.WriteLine(new string('*', width));
PrintCenteredLine("Спринт #4", width);
PrintCenteredLine("Тема: Создание решения по спринту", width);
PrintCenteredLine("Задание #6", width);
PrintCenteredLine("Вариант #1", width);
PrintCenteredLine("Выполнил: Мальцев Данил Вячеславович | РППБ-25-1", width);
Console.WriteLine(new string('*', width));
PrintCenteredLine("УСЛОВИЕ:", width);
PrintCenteredLine("Написать программу, подсчитывающую количество элементов массива больших 6", width);
Console.WriteLine(new string('*', width));
PrintCenteredLine("ИСХОДНЫЕ ДАННЫЕ:", width);
DataService ds = new DataService();
var Array = new string[] { "Яблоко", "Банан", "Вишня", "Драгонфрут", "Бузина", "Инжир", "Виноград" };
string s = "";
PrintCenteredLine("Исходный массив:", width);
for (int i = 0; i <= Array.Length - 1; i++)
{
    s += Array[i] + ", ";
}
PrintCenteredLine(s, width);
Console.WriteLine();
var res = ds.Calculate(Array);
Console.WriteLine(new string('*', width));
PrintCenteredLine("РЕЗУЛЬТАТ:", width);
Console.WriteLine(new string('*', width));
PrintCenteredLine($"Количество элементов массива длина которых больше 6: {res}", width);
Console.WriteLine(new string('*', width));
