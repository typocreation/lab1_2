using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string input = "A AND B OR NOT C";
        string pattern = @"\b(AND|OR|NOT)\b";

        MatchCollection matches = Regex.Matches(input, pattern);

        foreach (Match match in matches)
        {
            Console.WriteLine(match.Value);
        }
    }
}
