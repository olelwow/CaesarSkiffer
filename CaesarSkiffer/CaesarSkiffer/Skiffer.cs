using System.Text;
static class Skiffer
{
    public static char Cipher (char c, int shiftValue)
    {
        char d = ' ';
        if (!char.IsLetter(c))
        {
            return c;
            // Ifall char värdet man undersöker inte innehåller en bokstav returnerar man tecknet igen, till exempel ! och ?
        }
        if (char.IsUpper(c))
        {
            d = 'A';
        }
        else
        {
            d = 'a';
        }
        return (char)((((c + shiftValue) - d) % 26) + d);
    }
    public static string Encrypt (string message, int shiftValue)
    {
        string newMessage = string.Empty;
        foreach (char c in message)
        {
            newMessage += Cipher(c, shiftValue);
            // Kallar metoden Cipher för varje bokstav i message där bokstaven omvandlas beroende på shiftValue
            // Det nya meddelandet sparas i newMessage
        }

        return newMessage;
    }
    public static string Decrypt (string message, int shiftValue)
    {
        return Encrypt(message, 26 - shiftValue);
        // Kallar metoden Encrypt, istället för att addera shiftValue så subtraherar man shiftValue från 26 vilket
        // gör så att man går bakåt rätt antal steg för att avkryptera meddelandet.
    }
}