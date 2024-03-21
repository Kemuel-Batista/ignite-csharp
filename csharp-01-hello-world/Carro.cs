namespace csharp_01_hello_world;
class Carro
{
    public void Ligar()
    {
        Console.WriteLine("Carro ligado!");
    }

    public void Desligar()
    {
        Console.WriteLine("Carro desligado!");
    }

    // Modificadores de acesso

    private void Test1()
    {
        Console.WriteLine("Teste 1");
    }

    internal void Test2() 
    {
        Console.WriteLine("Teste 2");
    }
}
