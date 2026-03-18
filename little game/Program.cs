namespace little_game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Инициализируем генератор случайных чисел
            Random random = new Random();
            int secretNumber = random.Next(1, 101); // Число от 1 до 100
            int attempts = 0;
            int guess;

            Console.WriteLine("Добро пожаловать в игру «Угадай число»!");
            Console.WriteLine("Я загадал число от 1 до 100. Попробуйте угадать!");

            // Основной игровой цикл
            while (true)
            {
                Console.Write("Введите ваше предположение: ");
                string input = Console.ReadLine();

                // Проверяем, что введено число
                if (!int.TryParse(input, out guess))
                {
                    Console.WriteLine("Пожалуйста, введите целое число!");
                    continue;
                }

                attempts++;

                if (guess < secretNumber)
                {
                    Console.WriteLine("Слишком мало! Попробуйте больше.");
                }
                else if (guess > secretNumber)
                {
                    Console.WriteLine("Слишком много! Попробуйте меньше.");
                }
                else
                {
                    Console.WriteLine($"Поздравляю! Вы угадали число {secretNumber} за {attempts} попыток.");
                    break;
                }
            }

            Console.WriteLine("Спасибо за игру! Нажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}
