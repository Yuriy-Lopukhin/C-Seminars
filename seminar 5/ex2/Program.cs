Console.Clear();
int[] array = GetArray(123, 0, 1000);
int Sum = GetSum(array);

Console.WriteLine(String.Join(" ", array));
int userSum = GetSum(array);
Console.Write($"В заданном массиве {userSum} чисел(ла) лежат в промежутке от 10 до 99!");

//////////////////////////////////////////////////////////////////////////////////

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

int GetSum(int[] arr)
{
    int sum = 0;
    for (int i=0; i < arr.Length; i++)
    {
        if ((arr[i]>= 10) && (arr[i] <= 99)) sum ++;
    }
    return sum;
}
