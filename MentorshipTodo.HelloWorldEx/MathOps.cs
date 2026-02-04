namespace MentorshipTodo.HelloWorldEx;

public class MathOps
{
    // Utiliza expression-bodied members para operações simples
    public double Add(double value1, double value2) => value1 + value2;

    public double Subtract(double value1, double value2) => value1 - value2;

    public double Multiply(double value1, double value2) => value1 * value2;

    /// <summary>
    /// Realiza a divisão e retorna um tupla indicando sucesso e o resultado.
    /// </summary>
    public (double Result, bool Success, string Message) Divide(double value1, double value2)
    {
        if (value2 == 0)
        {
            return (0, false, "Erro: Divisão por zero não é permitida.");
        }

        // Cast explícito para garantir precisão decimal
        double quotient = (double)value1 / value2;
        return (quotient, true, "Sucesso: Operação realizada.");
    }
    
    public double CalculateAverage(double value1, double value2) 
        => (value1 + value2) / 2.0;
}