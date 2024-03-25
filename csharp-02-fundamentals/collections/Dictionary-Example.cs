namespace csharp_02_fundamentals.collections;

public class DictionaryExample
{
    static void DictionaryExampleFunction()
    {
        /* Exemplo 1:
       Dictionary<int, string> dicionario = new Dictionary<int, string>();
       dicionario.Add(1, "Welisson");
       dicionario.Add(58, "Edilaine");
       dicionario.Add(7, "Willian");

       string value = dicionario[2];
       */

        Dictionary<string, int> dicionario = new Dictionary<string, int>();
        dicionario.Add("Welisson", 1);
        dicionario.Add("Kemuel", 1);
        dicionario.Add("Edilaine", 0);
        dicionario.Add("Willian", 7);

        int value = dicionario["Welisson"];
        bool existe = dicionario.ContainsKey("Welisson");

        Console.WriteLine(value);
        Console.WriteLine(existe);
    }
}
