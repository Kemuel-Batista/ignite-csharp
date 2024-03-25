namespace csharp_02_fundamentals.anothers_data_types;

public class Objects
{
    public static void ObjectsExample()
    {
        var minhaVariavel = new Carro();

        minhaVariavel.Ligar();
    }
}

public class Carro
{
    public void Ligar()
    {
        Console.WriteLine("Ligar");
    }
}