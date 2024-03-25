namespace csharp_02_fundamentals.collections;

public class ListExample
{
    public static void AddList()
    {
        List<int> inteiros = new List<int>();

        inteiros.Add(1); // index: 0
        inteiros.Add(2); // index: 1

        // Primeiro elemento da lista:
        int primeiroElemento = inteiros.First();

        // Último elemento da lista:
        int ultimoElemento = inteiros.Last();

        int primeiroElemento1 = inteiros.ElementAt(0);

        inteiros.RemoveAt(0);

        // Remove todos os elementos da lista:
        inteiros.Clear();

        Console.WriteLine(inteiros.Count);
        Console.WriteLine(primeiroElemento1);

        List<string> strings = new List<string>();
        strings.Add("Hello");
        strings.Add("Mundo");

        string resultado = string.Join(" ", strings);

        Console.WriteLine(resultado);
    }
}
