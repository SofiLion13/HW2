// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

int GetNumber(string message)
{
    Console.WriteLine(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}
int number = GetNumber("Введите число дня недели от 1 до 7: ");

if (number > 0 && number < 8)
{
    if (number == 6 || number == 7)
    {
        Console.WriteLine("да");
    }
    else
    {
    Console.WriteLine("нет");
    }
}
else
{
    Console.WriteLine("Вы ввели не верное число");
}