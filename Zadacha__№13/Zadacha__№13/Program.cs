Console.Write("Введите трех значное число ");
int num = Convert.ToInt32(Console.ReadLine());
int a = num;
int result;

if (num < 100)
{
    Console.WriteLine("Так, ты опять за свое?");
}
else
{
    for (num = a;
        a > 1000;
        a = a / 10) ;
    result = a % 10;
    Console.WriteLine($"Вот и наша цифра {result}");
}
