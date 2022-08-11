Console.Write("Введите трехзначное число: ");
int num = int.Parse(Console.ReadLine());
int result=((num%100)/10);
Console.WriteLine($"Второе число {result} трехзначного числа {num}");
