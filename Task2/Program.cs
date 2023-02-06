// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите число: ");
int number1 = Convert.ToInt32(Console.ReadLine());

int ThirdDigit(int number)
{
    int result = -1;
    if (number >= 100)
    {
        while (number > 999)
            {
                number = number / 10;
            }
            result = number % 10;
    }
    return result; 
}

if (ThirdDigit(number1) == -1)
{
    Console.WriteLine("Третьей цифры нет");
}
else
{
    Console.WriteLine($"Третья цифра числа {ThirdDigit(number1)}");
}