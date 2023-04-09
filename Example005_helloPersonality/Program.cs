Console.WriteLine("Введите своё имя:");
string? username = Console.ReadLine();

if (username?.ToLower() == "оля")
    {
        Console.WriteLine("Рады тебя видеть, Оля!");
    }
else
    {
        Console.Write("Привет, ");
        Console.WriteLine(username);
    }
