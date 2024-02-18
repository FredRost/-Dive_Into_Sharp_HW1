namespace Dive_Into_Sharp_HW1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (args.Length != 3)
            {
                Console.WriteLine("Неправильное количество аргументов.");
                return;
            }

            // Получаем аргументы из командной строки
            double a = Convert.ToDouble(args[0]);
            char operation = Convert.ToChar(args[1]);
            double b = Convert.ToDouble(args[2]);
            double result = 0;

            // Выполняем операцию в зависимости от символа операции
            switch (operation)
            {
                case '+':
                    result = a + b;
                    break;
                case '-':
                    result = a - b;
                    break;
                case '*':
                    result = a * b;
                    break;
                case '/':
                    // Проверяем деление на ноль
                    if (b == 0)
                    {
                        Console.WriteLine("Деление на ноль невозможно.");
                        return;
                    }
                    result = a / b;
                    break;
                default:
                    Console.WriteLine("Неподдерживаемая операция.");
                    return;
            }

            // Выводим результат
            Console.WriteLine($"Результат: {result}");
        }
    }
}
