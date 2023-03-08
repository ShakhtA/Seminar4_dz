// Программа принимает на вход два числа (А и В)
// и возводит число А в натуральную степень В:
// 3, 5 -> 243
// 2, 4 -> 16

Console.Clear();

double number = InputNumber("Введите число А: ", "Ошибка ввода!"); // Ввод числа А - основания степени
int stepen = InputStepen("Введите натуральное число В: ", "Ошибка ввода!", "Введено не натуральное число."); // Ввод числа В - показателя степени
double result = GetStepen(number, stepen);   // Вычисление
Console.WriteLine($"{number}, {stepen} -> {result}");   // Вывод результата в терминал

//---------------БЛОК ОПИСАНИЙ---------------------------------------

static double InputNumber(string message_num, string error_message)
{
    double num; // Проверить как будет без = 0
    while (true)
    {
        Console.Write(message_num);
        bool correct = double.TryParse(Console.ReadLine(), out num);
        if (correct)
            return num;
        Console.WriteLine(error_message);
    }
}

static int InputStepen(string msg_get, string error_msg, string error_num)
{
    int num = 0;
    while (true)
    {
        try
        {        
            Console.Write(msg_get);
            num = int.Parse(Console.ReadLine() ?? ""); // Readline специально без модификаторов
            if (num > 0) 
                return num;
            Console.WriteLine(error_num);
        }
        catch (Exception exc)
        {
            Console.WriteLine($"{error_msg} {exc.Message}");
        }
    }
}

static double GetStepen(double num, int stepen)
{
    double res = num;
    for(int i = 1; i < stepen; i++)
        res *= num;
    return res;
}
