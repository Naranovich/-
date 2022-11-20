//Задача 19
//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.WriteLine("Введите число:");
string num = Console.ReadLine();
int len = num.Length;
if (len == 5){
    if(num[0] == num[4] && num[1] == num[3]){
        Console.WriteLine($"{num} - полиндром");
    }
    else{
        Console.WriteLine($"{num} - НЕ полиндром");
    }
}
else{
    Console.WriteLine($"{num} - не пятизначное число");
}