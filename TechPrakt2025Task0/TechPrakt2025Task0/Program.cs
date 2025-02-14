using System.Text;

Console.OutputEncoding = Encoding.UTF8;

Console.Write("Введіть перше число: ");
if (double.TryParse(Console.ReadLine(), out double number1))
{
    Console.Write("Введіть друге число: ");
    if (double.TryParse(Console.ReadLine(), out double number2))
    {
        double sum = number1 + number2;

        Console.WriteLine($"Сума чисел {number1} і {number2} дорівнює: {sum}");
    }
    else
    {
        Console.WriteLine("Некоректне друге число.");
    }
}
else
{
    Console.WriteLine("Некоректне перше число.");
}