Console.WriteLine("Добро пожаловать в игру 'Больше Меньше'");

Random rnd = new Random();
int numm = rnd.Next(0, 100);
Console.WriteLine($"{numm}");

Console.WriteLine("Я загадал число от 0 до 100. Попробуй отгадать...");
int otvet = Convert.ToInt32(Console.ReadLine());

while (otvet != numm)
{
    if (otvet < numm)
        Console.WriteLine("Больше");
    else
        Console.WriteLine("Меньше");

    Console.WriteLine("Попробуйте еще раз");
    otvet = Convert.ToInt32(Console.ReadLine());
};

Console.WriteLine("Поздравляю вы отгадали!");




