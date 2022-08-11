Console.Write("Введите число, обозначающее день недели ");
int num = int.Parse(Console.ReadLine());
if (num==6 || num==7)
{
    Console.WriteLine("Этот день выходной");
}
 else if (num <1 || num>7)
  {
    Console.WriteLine("Это не день недели");
      }
 
 else
 
{
 Console.WriteLine("Этот день не выходной");
}
 
