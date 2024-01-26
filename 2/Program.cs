using System;

class Program
{
    static void Main()
    {
        int choice;

        do
        {
            Console.WriteLine("Выберите программу:\n1. Игра \"Угадай число\"\n2. Таблица умножения\n3. Вывод делителей числа\n0. Выход");
            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    PlayGuessNumber();
                    break;
                case 2:
                    PrintMultiplicationTable();
                    break;
                case 3:
                    PrintDivisors();
                    break;
                case 0:
                    Console.WriteLine("Программа завершена");
                    break;
                default:
                    Console.WriteLine("Неверный выбор, попробуйте снова");
                    break;
            }

            Console.WriteLine();
        } while (choice != 0);
    }

    static void PlayGuessNumber()
    {
        Random random = new Random();
        int randomNumber = random.Next(0, 101);
        int guess;

        Console.WriteLine("Игра \"Угадай число\":");

        do
        {
            Console.Write("Введите число: ");
            guess = int.Parse(Console.ReadLine());

            if (guess < randomNumber)
            {
                Console.WriteLine("Загаданное число больше");
            }
            else if (guess > randomNumber)
            {
                Console.WriteLine("Загаданное число меньше");
            }

        } while (guess != randomNumber);

        Console.WriteLine("Поздравляю! Вы угадали число!");
    }

    static void PrintMultiplicationTable()
    {
        Console.WriteLine("Таблица умножения:");

        int[,] table = new int[10, 10];

        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                table[i, j] = (i + 1) * (j + 1);
            }
        }

        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                Console.Write(table[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }

    static void PrintDivisors()
    {
        Console.Write("Введите число: ");
        int number = int.Parse(Console.ReadLine());

        Console.Write("Делители числа {0}: ", number);

        for (int i = 1; i <= number; i++)
        {
            if (number % i == 0)
            {
                Console.Write(i + " ");
            }
        }

        Console.WriteLine();
    }
}
