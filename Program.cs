namespace MultiplicationTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;

            // Валидиране на въведеното число
            do
            {
                Console.WriteLine("Въведи число от 1 до 100 за таблицата за умножение:");
                n = int.Parse(Console.ReadLine());
;
                
                if (n < 1 || n > 100)
                {
                    Console.WriteLine();
                    Console.WriteLine("Моля, въведи валидно число от 1 до 100.");
                    Console.WriteLine();
                }

            } while (n < 1 || n > 100);

            // Таблица за умножение
            Console.WriteLine($"Таблица за умножение на {n}:");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{n} x {i} = {n * i}");
            }
        }
    }
}
