using Tyuiu.MalcevDV.Sprint4.Task4.V26.Lib;
DataService ds = new DataService();
void PrintCenteredLine(string text, int totalWidth)
{
    var padding = totalWidth - text.Length - 2; // -2 для звездочек по бокам
    Console.WriteLine($"* {text}{new string(' ', padding)}*");
}

var width = 75;

Console.WriteLine(new string('*', width));
PrintCenteredLine("Спринт #4", width);
PrintCenteredLine("Тема: Создание решения по спринту", width);
PrintCenteredLine("Задание #4", width);
PrintCenteredLine("Вариант #26", width);
PrintCenteredLine("Выполнил: Мальцев Данил Вячеславович | РППБ-25-1", width);
Console.WriteLine(new string('*', width));
PrintCenteredLine("УСЛОВИЕ:", width);
PrintCenteredLine("Написать программу, меняющую нечетные значения массива на 0", width);
Console.WriteLine(new string('*', width));
PrintCenteredLine("ИСХОДНЫЕ ДАННЫЕ:", width);
Console.WriteLine(new string('*', width));
Console.Write(" Введите количество строк в массиве: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write(" Введите количество столбцов в массиве: ");
int columns = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[rows, columns];
Console.WriteLine(new string('*', width));
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        Console.Write($" Введите [{i},{j}] элемент массива: ");
        array[i, j] = Convert.ToInt32(Console.ReadLine());
    }
}
Console.WriteLine(new string('*', width));

Console.WriteLine("\nМассив:");
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        Console.Write($"{array[i, j]} \t");
    }
    Console.WriteLine();
}
Console.WriteLine();
var res = ds.Calculate(array);
Console.WriteLine(new string('*', width));
PrintCenteredLine("РЕЗУЛЬТАТ:", width);
Console.WriteLine(new string('*', width));
Console.WriteLine(" Полученная матрица: ");
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        Console.Write($"{res[i, j]} \t");
    }
    Console.WriteLine();
}

Console.WriteLine(new string('*', width));