namespace net;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Console.WriteLine("whatisyourname");
        var name = Console.ReadLine();
        var currentDate = DateTime.Now;
        Console.WriteLine($"{Environment.NewLine}Hello, {name}, on {currentDate:d}, at {currentDate:t}");
        Console.WriteLine($"{Environment.NewLine}Press Any key to exit...");
        Console.ReadKey(true);
    }
}
