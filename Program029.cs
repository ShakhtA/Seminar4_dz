// Программа принимает на вход размер массива,
// значения массива и выводит их на экран

Console.Clear();

int length = InputSizeArray("Введите размер массива: ", "Ошибка ввода!");  // Ввод размера массива
int[] massiv = new int[length];
InputArray(massiv);                                                        // Ввод значений массива
PrintArray(massiv);                                                        // Вывод значений массива на экран

//------------------БЛОК ОПИСАНИЙ----------------------------------

static int InputSizeArray(string message_num, string error_message)
{
    int num;
    while (true)
    {
       Console.Write(message_num);      
       if (int.TryParse(Console.ReadLine(), out num) && num > 0)
            return num;
        Console.WriteLine(error_message);
    }
}

static void InputArray(int[] array)
{
    Console.WriteLine($"Введите {array.Length} чисел");
    int temp;
    for (int i = 0; i < array.Length; i++)
    {
        while (true)
        {
            if (int.TryParse(Console.ReadLine(), out temp))
                break;
            Console.WriteLine("Неверное число. Повторите ввод! ");
        }
        array[i] = temp;
    }    
}

static void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write($"{array[i]} ");
    Console.WriteLine();
}