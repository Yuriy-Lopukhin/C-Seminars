int[] array = new int[8];

FillArray(array);
PrintArray(array);

//Console.WriteLine($"[{String.Join(",", array)}]");
void FillArray(int[] array)
{
    int lenght = array.Length;
    for(int i = 0; i < lenght; i++)
    {
       array[i] = new Random().Next(0, 2);
    }

}

void PrintArray(int[] array)
{
  int lenght = array.Length;
    Console.Write("[");
    for(int i = 0; i < lenght; i++)
    {
      if (i < lenght-1) Console.Write($"{array[i]},");
      if (i == lenght-1) Console.Write($"{array[i]}");
      //Console.Write($"{array[i]}");
    }
//Console.Write($"{array[lenght-1]}");
Console.Write($"]");   
}