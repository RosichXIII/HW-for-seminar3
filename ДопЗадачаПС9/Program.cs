//Дана игра со следующими правилами.
//Первый игрок называет любое натуральное число от 2 до 9, второй умножает его на любое натуральное число от 2 до 9,
//первый умножает результат на любое натуральное число от 2 до 9 и т. д.
//Выигрывает тот, у кого впервые получится число больше 1000. Запрограммировать консольный вариант игры.

void DZPS9()
{
    int targetScore = 1000;
    int score = 1;
    int playerOrder = 0;
    int move = 0;
    Console.WriteLine($"Вводя натуральные числа от 2 до 9, наберите {targetScore} быстрее соперника! Fight!");
    while (score < targetScore)
    {
        playerOrder++;
        if (playerOrder%2 != 0)
        {
            Console.WriteLine("Ход Player 1");
            move = Convert.ToInt32(Console.ReadLine());;
            score = score*move;      
            if (move >= 2 & move <= 9)
            {
                Console.WriteLine("Good sport.");
            }
            else if (move > 9)
            {
                Console.WriteLine("Cheats, eh? Fine...");
            }
            else if (move == 1)
            {
                Console.WriteLine("Turn skip? Unintended feature.");
            }
            else if (move == 0)
            {
                Console.WriteLine("Rage quit?");
                playerOrder++;
                break;
            }
            else
            {
                if (score < 0)
                {
                    Console.WriteLine("To (-)infinity and beyond!");
                }
                else
                {
                    Console.WriteLine("Back on track.");
                }
            }
            Console.WriteLine($"Счёт: {score}");
            
        }
        else
        {
            Console.WriteLine("Ход Player 2");
            move =Convert.ToInt32(Console.ReadLine());
            score = score*move;
            if (move >= 2 & move <= 9)
            {
                Console.WriteLine("Good sport.");
            }
            else if (move > 9)
            {
                Console.WriteLine("Cheats, eh? Fine...");
            }
            else if (move == 1)
            {
                Console.WriteLine("Turn skip? Unintended feature.");
            }
            else if (move == 0)
            {
                Console.WriteLine("Rage quit?");
                playerOrder++;
                break;
            }
            else
            {
                if (score < 0)
                {
                    Console.WriteLine("To (-)infinity and beyond!");
                }
                else
                {
                    Console.WriteLine("Back on track.");
                }
            }
            Console.WriteLine($"Счёт: {score}");
        }
    }
    if (playerOrder%2 !=0)
    {
        Console.WriteLine("Player 1 wins!");
    }
    else
    {
        Console.WriteLine("Player 2 wins!");
    }
}
DZPS9();