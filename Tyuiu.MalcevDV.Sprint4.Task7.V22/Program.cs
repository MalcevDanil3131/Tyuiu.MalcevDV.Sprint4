using Tyuiu.MalcevDV.Sprint4.Task7.V22.Lib;
void PrintCenteredLine(string text, int totalWidth)
{
    var padding = totalWidth - text.Length - 2; // -2 для звездочек по бокам
    Console.WriteLine($"* {text}{new string(' ', padding)}*");
}

var width = 75;

Console.WriteLine(new string('*', width));
PrintCenteredLine("Спринт #4", width);
PrintCenteredLine("Тема: Создание итогового решения по спринту", width);
PrintCenteredLine("Задание #7", width);
PrintCenteredLine("Вариант #22", width);
PrintCenteredLine("Выполнил: Мальцев Данил Вячеславович | РППБ-25-1", width);
Console.WriteLine(new string('*', width));
PrintCenteredLine("УСЛОВИЕ: строка 695324951753684, которую нужно преобразовать в массив ", width);
PrintCenteredLine("Написать программу, вычисляющую произведение четных элементов массива", width);
Console.WriteLine(new string('*', width));
PrintCenteredLine("ИСХОДНЫЕ ДАННЫЕ:", width);
DataService ds = new DataService();
int n = 5;
int m = 3;
int[,] mtrx = new int[n, m];
string value = "695324951753684";



Console.WriteLine("Массив");
int[,] matrix = new int[n, m];
int count = 0;
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        matrix[i, j] = int.Parse(value[count].ToString());
        count++;
        Console.Write(matrix[i, j] + " ");
    }
    Console.WriteLine();
}

Console.WriteLine(new string('*', width));
PrintCenteredLine("РЕЗУЛЬТАТ:", width);
Console.WriteLine(new string('*', width));
PrintCenteredLine($"произведение четных чисел : " + ds.Calculate(n, m, value), width);
Console.WriteLine(new string('*', width));
