Console.Write("Введите число: ");
int userNumber1 = int.Parse(Console.ReadLine() ?? "");

int result1 = userNumber1 % 23;
int result2 = userNumber1 % 7;

if (result1 == 0 && result2 == 0) 
{
    Console.WriteLine($"{userNumber1} кратно 23 и 7");
}
else
{
    Console.WriteLine($"{userNumber1} не кратно 23 и 7 остаток = {result1} {result2}");
}