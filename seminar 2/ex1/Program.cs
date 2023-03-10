Console.Write("Введите 1е число: ");
int userNumber1 = int.Parse(Console.ReadLine() ?? "");
Console.Write("Введите 2е число: ");
int userNumber2 = int.Parse(Console.ReadLine() ?? "");

int result = userNumber1 % userNumber2;
if (result == 0)
{
    Console.WriteLine($"{userNumber1} кратно {userNumber2}");
}
else
{
    Console.WriteLine($"{userNumber1} не кратно {userNumber2} остаток = {result}");
}