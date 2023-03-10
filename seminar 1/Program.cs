Console.Write("Введите целое число: ");

string UserInputStr = Console.ReadLine() ?? "";
int UserNumber = int.Parse(UserInputStr);

int result = UserNumber * UserNumber;

Console.WriteLine($"{UserNumber} -> {result}");

