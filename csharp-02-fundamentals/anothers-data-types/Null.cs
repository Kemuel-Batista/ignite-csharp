namespace csharp_02_fundamentals.anothers_data_types;

public class Null
{
    public void Main()
    {
        int? idade = null;

        int minhaIdade = idade.Value;
        bool informouIdade = idade.HasValue;
    }
}
