Console.WriteLine("Введите число N");
int nums = int.Parse(Console.ReadLine());
Numbers(nums);
int count = 0;
void Numbers(int num)
{
    if(num == 0)
    {
       return;
    }
    Console.Write($"{num},");
    Numbers(num -1);
}