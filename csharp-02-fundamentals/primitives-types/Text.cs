namespace csharp_02_fundamentals.primitives_types;

public class text
{
    public void Main()
    {
        char letter = 'a';
        char number = '1';
        char caracter '@';

        string text = "Este curso é muito bom";
        char firstLetterOftext = text[0];

        Console.WriteLine(text);
        Console.WriteLine(firstLetterOftext);

        string myName = "       Kemuel Batista        ";
        string nameWithoutSpace = myName.Trim();

        Console.WriteLine(myName);
        Console.WriteLine(nameWithoutSpace);

        bool startsWithW = nameWithoutSpace.StartsWith("W"); // Camel Case

        Console.WriteLine(startsWithW);

        // Replace 
        string textAfterReplace = nameWithoutSpace.Replace("e", "7");

        Console.WriteLine(textAfterReplace);

        string text2 = "Este curso é muito bom";

        bool exists = text2.Contains("Curso");

        Console.WriteLine(exists);
    }
}
