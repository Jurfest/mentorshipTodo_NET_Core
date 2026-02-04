namespace MentorshipTodo.HelloWorld;

public class MathOperations
{
    public int Add(int valor1, int valor2)
    {
        var result = valor1 + valor2;
        return result;
    }
    
    public int Subtract(int valor1, int valor2)
    {
        var result = valor1 - valor2;
        return result;
    }

    public int Multiply(int value1, int value2) => value1 * value2;
    
    public (double result, string message) Divide(int value1, int value2) 
    {
        if (value2 == 0) 
        {
            return (0, "Erro: Divisão por zero não é permitida.");
        }

        double quotient = (double)value1 / value2;
        return (quotient, "Sucesso: Operação realizada.");
    }
}