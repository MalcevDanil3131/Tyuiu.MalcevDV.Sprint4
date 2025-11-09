using Tyuiu.MalcevDV.Sprint4.Task0.V22.Lib;
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
int[] array = new int[] { 9, 5, 7, 4, 5, 3, 7, 8, 9, 1 };
for (int i = 0; i < array.Length; i ++)
{
    Console.Write(array[i] + " ");
}
Console.WriteLine();
var res = ds.GetSumOddArrEl(array);
Console.WriteLine(new string('*', width));
PrintCenteredLine("РЕЗУЛЬТАТ:", width);
Console.WriteLine(new string('*', width));
PrintCenteredLine($"Сумма нечетных элемнентов: {res}", width);
Console.WriteLine(new string('*', width));
