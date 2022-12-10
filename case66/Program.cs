Console.WriteLine("Введите  число N:");
int numberM = int.Parse(Console.ReadLine());

Console.WriteLine("Введите  число M:");
int numberN = int.Parse(Console.ReadLine());

///Метод нахождения суммы натуральных элементов в промежутке от M до N
void NumberSum (int numberM, int numberN, int sum)
{
    if (numberM > numberN) 
    {
        Console.WriteLine($"Сумма натуральных элементов в промежутке от M до N: {sum}"); 
        return;
    }
    sum = sum + (numberM++);
    NumberSum(numberM, numberN, sum);
}

NumberSum(numberM, numberN, 0);