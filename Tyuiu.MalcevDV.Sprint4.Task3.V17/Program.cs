using Tyuiu.MalcevDV.Sprint4.Task3.V17.Lib;
DataService ds = new DataService();

int[,] array = new int[5, 5] { 
    { 6, 4, 2, 2, 1 },
    { 3, 6, 5, 4, 1 },
    { 5, 2, 3, 1, 6 },
    { 8, 8, 4, 5, 3 },
    { 7, 4, 5, 1, 6} };
int rows = array.GetUpperBound(0) + 1;
int columns = array.Length / rows;
void PrintCenteredLine(string text, int totalWidth)
{
    var padding = totalWidth - text.Length - 2; // -2 для звездочек по бокам
    Console.WriteLine($"* {text}{new string(' ', padding)}*");
}

var width = 75;

Console.WriteLine(new string('*', width));
PrintCenteredLine("Спринт #4", width);
PrintCenteredLine("Тема: Создание решения по спринту", width);
PrintCenteredLine("Задание #3", width);
PrintCenteredLine("Вариант #17", width);
PrintCenteredLine("Выполнил: Мальцев Данил Вячеславович | РППБ-25-1", width);
Console.WriteLine(new string('*', width));
PrintCenteredLine("УСЛОВИЕ:", width);
PrintCenteredLine("Написать программу, подсчитывающий сумму элементов 4 столбца массива", width);
Console.WriteLine(new string('*', width));
PrintCenteredLine("ИСХОДНЫЕ ДАННЫЕ:", width);
Console.WriteLine(new string('*', width));
for(int i = 0; i < rows; i++)
            {
    for (int j = 0; j < columns; j++)
    {
        Console.Write($"{array[i, j]} \t", width);
    }
    Console.WriteLine();
}
Console.WriteLine();
var res = ds.Calculate(array);
Console.WriteLine(new string('*', width));
PrintCenteredLine("РЕЗУЛЬТАТ:", width);
Console.WriteLine(new string('*', width));
PrintCenteredLine($"Сумма элементов 4 столбца: {res}", width);
Console.WriteLine(new string('*', width));