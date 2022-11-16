//Задача 10: Напишите программу, которая принимает на вход трёхзначное число
// и на выходе показывает вторую цифру этого числа.
int number = new Random().Next(100, 1000);
Console.WriteLine($"случайное число {number}");
string numberS = Math.Abs(number).ToString();
Console.WriteLine(numberS.Length == 3 ? $"{number} -> {numberS[1]}" : "результат");