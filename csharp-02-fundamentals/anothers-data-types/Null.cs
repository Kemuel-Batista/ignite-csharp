namespace csharp_02_fundamentals.anothers_data_types;

public class Null
{
    public static void NullExample()
    {
        int? idade = null;

        int minhaIdade = idade.Value;
        bool informouIdade = idade.HasValue;
    }
}
