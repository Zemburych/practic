// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.Clear();
Console.WriteLine("Введите трехзначное число.\n");
int input = Convert.ToInt32(Console.ReadLine());
string Text = Convert.ToString(input);
if (Text.Length < 2)
{
    Console.WriteLine("третья цифра - " + Text[2]);
}
else
{
    Console.WriteLine("третьей цифры нет");
}
