class Program 
{
    static void Main(string[] args)
    { 
        bool isRunning = true;

        while (isRunning)
        {
            Menu.PrintStartMenu();
            string inputChoice = Console.ReadLine();
            // Skriver ut startmenyn samt läser in input från användaren.
            switch (inputChoice)
            {
                case "1":
                    Menu.PrintEnterMessage("encrypted");
                    string userMessage = Console.ReadLine();
                    Menu.PrintSelectShiftValue();
                    bool correctInput = Int32.TryParse(Console.ReadLine(), out int shiftValue);
                    // Inläsning av meddelande samt "krypteringsnyckel", ifall man anger något annat än en integer får man ett felmeddelande,
                    // och man får försöka igen tills man anger en integer. Man får även felmeddelandet ifall man anger ett negativt tal, eller ett
                    // tal som är större än 26.
                    while (!correctInput || (shiftValue < 1 || shiftValue > 26))
                    {
                        Menu.PrintSelectShiftValue("only integers between 1-26");
                        correctInput = Int32.TryParse(Console.ReadLine(), out shiftValue);
                    }

                    string encryptedMessage = Skiffer.Encrypt(userMessage, shiftValue);
                    Console.WriteLine($"Encrypted message: {encryptedMessage}");
                    // Kallar metoden Encrypt som tar in meddelandet och skickar ut en krypterad version, sedan skrivs det krypterade meddelandet ut.
                    break;

                case "2":
                    Menu.PrintEnterMessage("decrypted");
                    userMessage = Console.ReadLine();
                    Menu.PrintSelectShiftValue();
                    correctInput = Int32.TryParse(Console.ReadLine(), out shiftValue);
                    
                    while (!correctInput || (shiftValue < 1 || shiftValue > 26))
                    {
                        Menu.PrintSelectShiftValue("only integers between 1-26");
                        correctInput = Int32.TryParse(Console.ReadLine(), out shiftValue);
                    }

                    string decryptedMessage = Skiffer.Decrypt(userMessage, shiftValue);
                    Console.WriteLine($"Decrypted message: {decryptedMessage}");
                    // Kallar metoden Decrypt som tar in ett krypterat meddelande och skickar ut ett avkrypterat meddelande, sedan skrivs meddelandet ut.
                    break;

                case "3":
                    Console.WriteLine("Program deleted. Your messages are safe.");
                    isRunning = false;
                    // Stänger av programmet ifall användaren trycker 3
                    break;

                default:
                    Console.WriteLine("Wrong input, choose either 1, 2 or 3.");
                    // Ifall användaren skriver in något annat än 1, 2 eller 3 skickas man tillbaka till början av programmet och meddelandet ovan skrivs ut.
                    break;
            }
        }
    }
}