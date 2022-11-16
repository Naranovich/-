Console.WriteLine("Введите цифру обозначающую день недели:");
int num = Convert.ToInt32(Console.ReadLine());
string numberS = (num > 0 && num < 8) 
    ? (num == 6 || num == 7) ? "Выходной" : "рабочий день"
    : "не день недели";
Console.WriteLine($"{num} -> {numberS}");
