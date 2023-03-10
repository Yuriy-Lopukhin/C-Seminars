int lenght = InputNumber("Введите длину массива: ");
int min = InputNumber("Введите минимальное значение: ");
int max = InputNumber("Введите максимальное значение: ");
int userNumber = InputNumber("Введите число: ");
int[] array = GetArray(lenght, min, max);
Console.WriteLine(String.Join(" ", array));
bool isUserNumber = CheckElements(array, userNumber);
Console.WriteLine($"{userNumber} -> {(isUserNumber ? "Да!" : "Нет!")}");
//////////////////////////////////////////////////////////////////////////////////

static int InputNumber(string message)
{
    try
    {
        Console.Write(message);
        return (int.Parse(Console.ReadLine() ?? ""));
    }
    catch (Exception exc)
    {
        Console.WriteLine($"Ошибка ввода данных! {exc.Message}");
        return 0;
    }
}

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

bool CheckElements(int[] arr, int value)
{
    bool test = false;
        foreach (int el in arr)
    {
        if (el == value) test = true;
    }
    return test;   

}
