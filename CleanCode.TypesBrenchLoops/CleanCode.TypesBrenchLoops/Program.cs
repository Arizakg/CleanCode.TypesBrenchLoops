// See https://aka.ms/new-console-template for more information




Console.OutputEncoding = System.Text.Encoding.UTF8;

Console.WriteLine("Добро пожаловать в игру 'Угодай число'\nПрошу введите своё имя:");
string? userName = Console.ReadLine().ToString();
Console.WriteLine("Привет {0}\nЯ загадаю число а ты попробуешь его угодать\nУ тебя будет несколько попыток\nТы готов сыграть Y/N:", userName);
//ConsoleKey userStartGame = ConsoleKey.A;
ConsoleKey userStartGame = Console.ReadKey().Key;

while (userStartGame != ConsoleKey.N)
{
    switch (userStartGame)
    {
        case ConsoleKey.Y:
            gameProces();
            break;

        default:
            Console.WriteLine("\n{0} \nДля старта игры нажмите Y\nДля выхода нажмите N\nПопробуем еще раз:", userName);
            break;
    }
    ConsoleKey key = Console.ReadKey().Key;
    userStartGame = key;
}

        
Console.WriteLine("\nПока пока {0}", userName);


void gameProces()
{
    Random random = new Random();
    int value = random.Next(0, 99);

    Console.Write("\nЯ загадал число от 0 до 99, попробуй угодай:");
    int userAnswer = int.Parse(Console.ReadLine());

    while (value != userAnswer)
    {
        if (value > userAnswer)
        {
            Console.Write("\nЯ загадал число больше, попробуй еще раз:");
        }
        if (value < userAnswer)
        {
            Console.Write("\nЯ загадал число меньше, попробуй еще раз:");
        }

        int newUserAnswer = int.Parse(Console.ReadLine());
        userAnswer = newUserAnswer;
    }

    Console.WriteLine("\nДа это число {0} \nТы победил поздравляю!!!", value);
}





