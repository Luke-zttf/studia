internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Console.WriteLine("Jak Masz na imię?");
        string ?imie = Console.ReadLine();
        Console.WriteLine($"Cześć buraku, {imie}!");
    }
}