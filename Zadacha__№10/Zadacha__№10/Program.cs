Console.Write("Введите трёхзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num > 999)
{
    Console.WriteLine("А ты точно умеешь считать?");
}
else if (num < 100)
{
    Console.WriteLine("Ты уверен?");
}
else
{
    int a = num % 100; int b =a / 10;
    Console.WriteLine($"Вторая цифра {b}");
}
