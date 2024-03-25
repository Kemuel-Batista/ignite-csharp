namespace csharp_02_fundamentals.collections;

public class HashSetTwo
{
    static void HashSetExample()
    {
        // Parecido com uma lista
        // Um hashset não podem ter valores duplicados
        HashSet<int> set = new HashSet<int>();

        set.Add(1);
        set.Add(2);
        set.Add(1); // Nothing to do, duplicated value on set

        Console.WriteLine(set.Count);
    }
}
