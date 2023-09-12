class Program
{
    static void Main()
    {
        while (true)
        {
            int number1 = 0, number2 = 0, quantityDigit = 1, quantityZero = 0, b;
            Console.WriteLine("Введите натур число:");
            try
            {
                number1 = number2 = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Ошибка!");
                continue;
            }
            if (number1 < 0)
            {
                Console.WriteLine("Ошибка! число должно быть натуральным");
                continue;
            }
            while (number1 / 10 != 0)
            {
                quantityDigit++;
                number1 /= 10;
            }
            number1 = number2;
            int[] array = new int[quantityDigit];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = number1 % 10;
                number1 /= 10;
                if (array[i] == 0)
                    quantityZero++;
            }
            Array.Sort(array);
            if (number2 != 0)
            {
                b = array[quantityZero];
                array[quantityZero] = array[0];
                array[0] = b;
            }
            for (int i = 0; i < array.Length; i++)
                Console.Write(array[i]);
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("\n\tПовторить?(enter - Да, др.кл. + enter - НЕТ)\t\t");
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;
            string proverka = Convert.ToString(Console.ReadLine());
            if (proverka != "")
                break;
        }
    }
}