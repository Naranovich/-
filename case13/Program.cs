//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.WriteLine("Введите трехзначное число:");
int number = Convert.ToInt32(Console.ReadLine());
string numberS = Math.Abs(number).ToString();
Console.WriteLine(numberS.Length == 3 ? $"{number} -> {numberS[2]}" : "Это не трехзначное число");