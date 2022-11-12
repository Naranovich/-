// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
 Console.WriteLine("Введите число:");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Чётные числа от 1 до  {num}");
 int i=1;
while (i <= num)
    {
         if (i % 2 != 1)
     {
         Console.Write(i + ",");
        
     }
         i++;
     }
