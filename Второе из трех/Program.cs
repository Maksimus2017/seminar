Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());
if (num<1||num<99)
{
    Console.WriteLine("Третьего числа нет");
}
else if(num>100)
{int result=(num/100);

Console.WriteLine($"Третье число {result} заданного числа {num}");}
