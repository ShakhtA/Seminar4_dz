// Программа принимает на вход число и выдает сумму чисел в числе:
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Clear();

int number = GetNamber("Введите число: ", "Ошибка ввода: ");    // Ввод числа
int result = GetSum(number);                                    // Получение результата
Console.WriteLine($"{number} -> {result}");                     // Вывод на экран

//--------------БЛОК ОПИСАНИЙ---------------------------------

static int GetNamber(string message_num, string error_message)
{
    int num;
    while (true)
    {
        Console.Write(message_num);
        if (int.TryParse(Console.ReadLine(), out num))
            return num;
        Console.WriteLine(error_message);
    }
}

static int GetSum(int num)
{
    int res = 0;
    if (num < 0)
        num = num * (-1);
    while (num != 0)
    {
        res = res + num % 10;
        num /= 10;
    }

    return res;
}

