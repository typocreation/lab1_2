using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string input = "A == B && C != D || E < F >= G";
        string pattern = @"\b(==|!=|<=|>=|<|>)\b";

        MatchCollection matches = Regex.Matches(input, pattern);

        foreach (Match match in matches)
        {
            Console.WriteLine(match.Value);
        }
    }
}
