// Задача 26. Напишите программу, которая принимает на вход число (А)
// и выдаёт количество цифр в числе ( 456 -> 3 )
Console.Clear();
int num = GetNumberFromUser("Введите целое число A: ", "Ошибка ввода!");
int Numbers = GetNumbers(num);
Console.WriteLine($"{num} -> {Numbers}");


//////////////////////////////////////////////////////////////////////////////////////
int GetNumberFromUser(string message, string errorMessage)
{
    while (true)
    {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
        if (isCorrect)
            return userNumber;
        Console.WriteLine(errorMessage);
    }
}


int GetNumbers(int number)
{
     int pov = 1;
     int res = 0;
    while (number/10 > 0)
    {
        pov = (number/10)%10;
        res = res + pov;
        number--;
    }
    return pov;
}
