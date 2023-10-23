static class Menu
{
    public static void PrintEnterMessage(string message)
    {
        Console.Clear();
        Console.WriteLine($"Enter message to be {message}:");
        Console.Write(">");
    }
    public static void PrintSelectShiftValue()
    {
        Console.WriteLine("Select shift value between 1-26");
        Console.Write(">");
    }
    public static void PrintSelectShiftValue(string message)
    {
        Console.WriteLine($"Select a shift value, {message}");
        Console.Write(">");
    }
    public static void PrintStartMenu()
    {
        Console.WriteLine("\nWelcome to Top Secret Gigachad Encryption Service\n\n" +
                          "-------------------------------------------------\n" +
                          "Please choose an operation below\n" +
                          "1. Encrypt\n" +
                          "2. Decrypt\n" +
                          "3. Exit program\n" +
                          "-------------------------------------------------");
        Console.Write(">");
    }
    // Metoder för att undvika upprepning i min Main metod, dessa sköter utskrifterna i programmet.
}