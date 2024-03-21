namespace csharp_02_fundamentals.anothers_data_types;

public class Enums
{
    enum NivelDeDificuldade
    {
        Baixo = 0,
        Medio = 1,
        Alto = 2
    }

    public void Main()
    {
        NivelDeDificuldade nivel = NivelDeDificuldade.Alto;

        int nivelInteiro = (int)nivel;

        Console.WriteLine(nivel);
        Console.WriteLine(nivelInteiro);
    }
}
