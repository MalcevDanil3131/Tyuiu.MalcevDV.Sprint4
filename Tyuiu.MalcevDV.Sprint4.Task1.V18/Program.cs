using Tyuiu.MalcevDV.Sprint4.Task1.V18.Lib;
void PrintCenteredLine(string text, int totalWidth)
{
    var padding = totalWidth - text.Length - 2; // -2 для звездочек по бокам
    Console.WriteLine($"* {text}{new string(' ', padding)}*");
}

var width = 75;

Console.WriteLine(new string('*', width));
PrintCenteredLine("Спринт #4", width);
PrintCenteredLine("Тема: Создание решения по спринту", width);
PrintCenteredLine("Задание #1", width);
PrintCenteredLine("Вариант #18", width);
PrintCenteredLine("Выполнил: Мальцев Данил Вячеславович | РППБ-25-1", width);
Console.WriteLine(new string('*', width));
PrintCenteredLine("УСЛОВИЕ:", width);
PrintCenteredLine("Написать программу, подсчитывающую сумму нечетных элементов массива", width);
Console.WriteLine(new string('*', width));
PrintCenteredLine("ИСХОДНЫЕ ДАННЫЕ:", width);
DataService ds = new DataService();
int len = 16;
int[] array = new int[len];
Console.WriteLine("Ведите значения массива");   
for (int i = 0; i < array.Length; i++)
{
    while (true)
    {
        Console.Write($"Элемент [{i + 1}]: ");
        var x = Convert.ToInt32(Console.ReadLine());
        if (x >= 3 && x <= 9)
        {
            array[i] = x;
            break;
        }
        else
        {
            Console.WriteLine("Некорректный ввод, введите число от 3 до 9");
        }
    }
}
Console.WriteLine("Массив:");
for (int i = 0; i < 16; i++)
{
    Console.WriteLine(array[i] + " ");
}
var res = ds.Calculate(array);
Console.WriteLine(new string('*', width));
PrintCenteredLine("РЕЗУЛЬТАТ:", width);
Console.WriteLine(new string('*', width));
PrintCenteredLine($"Сумма нечетных элемнентов: {res}", width);
Console.WriteLine(new string('*', width));
