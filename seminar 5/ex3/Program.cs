Console.Clear();
int lenght = InputNumber("Введите длину массива: ");
int min = InputNumber("Введите минимальное значение: ");
int max = InputNumber("Введите максимальное значение: ");
int[] array = GetArray(lenght, min, max);
Console.WriteLine(String.Join(" ", array));
Console.WriteLine();
ExchangeElements(array);
Console.WriteLine(String.Join(" ", array));


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

void ExchangeElements(int[] arr)
{
    for (int i=0 ; i<arr.Length; i++)
    {
        arr[i] = arr[i] * -1;
    }
}
