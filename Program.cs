using System.Text.RegularExpressions;

public class Kata
{
    public static string Shortcut(string input)
    {
        // TODO: Remove vowels
        return Regex.Replace(input, "[aeiou]", "");
    }
}

