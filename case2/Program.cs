//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.WriteLine("Введите три числа");
int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = Convert.ToInt32(Console.ReadLine());
int num3 = Convert.ToInt32(Console.ReadLine());
int max = num1;
if(num2 > max)
{
    num2 = max;
}
if(num3 > max)
{
    num3 = max;
}
Console.WriteLine($"Максимум равен {max}");



