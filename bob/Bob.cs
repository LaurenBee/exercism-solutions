using System.Linq;


public static class Bob
{
    public static string Response(string statement)
    {
        string trimmedStatement = statement.Trim();

        bool isAQuestion = trimmedStatement.EndsWith("?");
        
        bool isYelled = IsUpperCase(trimmedStatement) && IsLetters(trimmedStatement);
        
        bool isAYelledQuestion = isYelled && isAQuestion;

        
        if (string.IsNullOrEmpty(trimmedStatement)) {
            return "Fine. Be that way!";
        } if (isAYelledQuestion) {
            return "Calm down, I know what I'm doing!";
        } if (isAQuestion) {
            return "Sure.";           
        } 
        return isYelled ? "Whoa, chill out!" : "Whatever.";
    }

    private static bool IsUpperCase(string value) => value == value.ToUpper();

    private static bool IsLetters(string trimmedStatement) => trimmedStatement.Any(char.IsLetter);

    // Managed to use Regex at one point but I don't really like it so used LINQ instead.
    
        // Regex numbersRegex = new Regex("[0-9]");
        // Regex alphaRegex = new Regex ( "[a-zA-Z]");
        // bool containsLetters = alphaRegex.IsMatch(statement);
        // bool doesNotContainLetters = alphaRegex.IsMatch(statement) == false;

}