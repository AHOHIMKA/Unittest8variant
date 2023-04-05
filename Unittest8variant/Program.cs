namespace Unittest8variant;
class Program
{
    static void Main(string[] args)
    {
        Reshenie Example_class = new Reshenie();

        double a = 0, c = 0, x = 0, result = 0;
        result = Example_class.Example_method(a, c, x, result);
        Console.WriteLine("Результат: " + result);
        Console.ReadKey();
    }
}

