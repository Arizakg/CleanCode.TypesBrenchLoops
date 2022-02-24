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
    }

    Console.WriteLine("\n{0} \nДля старта игры нажмите Y\nДля выхода нажмите N\nПопробуем еще раз:", userName);
    ConsoleKey key = Console.ReadKey().Key;
    userStartGame = key;
}

        
Console.WriteLine("\n\nПока Пока {0}", userName);



void gameProces()
{
    Random random = new Random();
    int secretNumber = random.Next(0, 100);  

    int userAnswer = -1;
    bool isIntNumber = false;

    Console.Write("\nЯ загадал число от 0 до 100, попробуй угодай:");

    while (secretNumber != userAnswer)
    {
        do
        {            
            isIntNumber = int.TryParse(Console.ReadLine(), out userAnswer);

            if (!isIntNumber)
            {
                Console.Write("Вы ввели какуюто фигню, введите число:");
            }

        } while (!isIntNumber);


        if (secretNumber > userAnswer)
        {
            Console.Write("Я загадал число больше, попробуй еще раз:");
        }
        if (secretNumber < userAnswer)
        {
            Console.Write("Я загадал число меньше, попробуй еще раз:");
        }
        if (secretNumber == userAnswer) 
        {
            Console.WriteLine("\nДа это число {0} \nТы победил поздравляю!!!", secretNumber);
        }
    }   
}





