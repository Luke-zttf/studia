internal class Program
{
    private static void Main(string[] args)
    {
        Podprogram1();
        Console.WriteLine(4+4);
        Console.WriteLine("4"+"4");
    }

    static void Podprogram1()
    {
        string szkola = "Szkola Podstawowa";
        Console.WriteLine("Hello, World!");
        Console.WriteLine("Jak Masz na imię?");
        string ?imie = Console.ReadLine();
        Console.WriteLine($"Cześć buraku, {imie}, nie zdajesz {szkola}");
    }
}