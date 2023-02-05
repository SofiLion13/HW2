//  Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

int GetNumber(string message)
{
    Console.WriteLine(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}
int number = GetNumber("Введите трехзначное число: ");

// 2. Оставить 2 цифру числа
int GetTheSecondNumber(int number)
{
    int secondDigit = number / 10 % 10;
    return secondDigit;
}
int result = GetTheSecondNumber(number);

Console.WriteLine($"Было: {number} Стало: {result}");