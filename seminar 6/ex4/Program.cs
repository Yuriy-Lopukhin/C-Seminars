int lenght = InputNumber("Введите длину массива: ");
int min = InputNumber("Введите минимальное значение: ");
int max = InputNumber("Введите максимальное значение: ");
int[] array = GetArray(lenght, min, max);
int[] secondArray = GetCopyArray(array);
Console.WriteLine($"{String.Join("", array)}");
Console.WriteLine();
Console.WriteLine($"{String.Join("", secondArray)}");

////////////////////////////////////////////////////////////////////////////////////////////////////////
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

int[] GetCopyArray(int[] arr)
{
    int[] res = new int[arr.Length];
    for (int i = 0; i < arr.Length; i++)
    {
        res[i] = arr[i];
    }
    return res;
}

