Console.Write("Введите первое число: ");
int userNumber1 = int.Parse(Console.ReadLine() ?? "");

Console.Write("Введите второе число: ");
int userNumber2 = int.Parse(Console.ReadLine() ?? "");

if ((userNumber1 == userNumber2 * userNumber2) || (userNumber2 == userNumber1 * userNumber1))
{
    Console.WriteLine($"{userNumber1}, {userNumber2} -> Да");
}
else
{
    Console.WriteLine($"{userNumber1}, {userNumber2} -> Нет");
}