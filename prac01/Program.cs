// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.Clear();
Console.WriteLine("Введите трехзначное число.\n");
while (true)
{
    string input = Console.ReadLine();

    Console.WriteLine("Вторая цифра - {1}", input, input[1]);
    break;
}
