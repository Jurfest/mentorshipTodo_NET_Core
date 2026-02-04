namespace MentorshipTodo.HelloWorldEx;

public class LegacyBrazilianPlateValidator
{
    /// <summary>
    /// Valida se a placa segue o padrão brasileiro pré-2018 (AAA1234) digitado sem hífen.
    /// </summary>
    public bool IsValid(string plate)
    {
        // 1. Verifica se a placa tem exatamente 7 caracteres
        if (string.IsNullOrWhiteSpace(plate) || plate.Length != 7)
        {
            return false;
        }

        // 2. Verifica se os 3 primeiros caracteres são letras
        for (int i = 0; i < 3; i++)
        {
            if (!char.IsLetter(plate[i]))
            {
                return false;
            }
        }

        // 3. Verifica se os 4 últimos caracteres são números
        for (int i = 3; i < 7; i++)
        {
            if (!char.IsDigit(plate[i]))
            {
                return false;
            }
        }

        // Se passou por todos os filtros, é válida
        return true;
    }
}