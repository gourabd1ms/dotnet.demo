namespace App;

public static class Greeter
{
    public static string Greet() => "Hello from .NET demo!";
}

public class Program
{
    public static void Main()
    {
        Console.WriteLine(Greeter.Greet());
    }
}
