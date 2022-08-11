//Дано трехзначное число убрать второе число в нем и получить двухзначное число.

int num = new Random().Next(100,1000);
int result =(num/100)*10+num%10;
Console.WriteLine($" {num}  {result}");
