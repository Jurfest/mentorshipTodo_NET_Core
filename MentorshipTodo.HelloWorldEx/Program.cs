// See https://aka.ms/new-console-template for more information

// 1
using System.Globalization;
using MentorshipTodo.HelloWorldEx;

Console.WriteLine("Ex 1:");
Console.WriteLine("=)\nPor favor, digite seu nome: ");
string name = Console.ReadLine();
Console.WriteLine($"Olá, {name}! Seja muito bem-vindo!");
Console.WriteLine("--------------------------------------\n");

// 2
Console.WriteLine("Ex 2:");
Console.WriteLine("=)\nPor favor, digite seu primeiro nome: ");
string firstName = Console.ReadLine();
Console.WriteLine("\nPor favor, digite seu sobrenome: ");
string surname = Console.ReadLine();
string fullName = $"{firstName} {surname}";

Console.WriteLine($"Olá, {fullName}!");
Console.WriteLine("--------------------------------------\n");

// 3
double firstNum = 4;
double secondNum = 5;

MathOps mathOps = new MathOps();
var sum = mathOps.Add(firstNum, secondNum);
Console.WriteLine($"{firstNum} + {secondNum} = {sum}");
var diff = mathOps.Subtract(value1: firstNum, value2: secondNum);
Console.WriteLine($"{firstNum} - {secondNum} = {diff}");
var mult = mathOps.Multiply(firstNum, secondNum);
Console.WriteLine($"{firstNum} * {secondNum} = {mult}");
var quotient = mathOps.Divide(firstNum, secondNum);
Console.WriteLine($"{firstNum} / {secondNum} = {quotient}");
var average = mathOps.CalculateAverage(firstNum, secondNum);
Console.WriteLine($"Média entre {firstNum} e {secondNum} é {average}");

// 4
Console.WriteLine("=)\nPor favor, digite uma frase para contar seus caracteres validos: ");
string phrase = Console.ReadLine();
int numChart = phrase is null ? 0 : phrase.Trim().Length;
Console.WriteLine($"Caracteres: {phrase.Length}");

// 5
Console.WriteLine("=)\nPor favor, digite a placa do veículo para valida-la: ");
string plate = Console.ReadLine();
LegacyBrazilianPlateValidator brazilianPlateValidator = new LegacyBrazilianPlateValidator();
bool isValid = brazilianPlateValidator.IsValid(plate);
string plateValidRes = isValid ? "Verdadeiro" : "Falso";
Console.WriteLine($"{plateValidRes}");

//6
var culture = new CultureInfo("pt-BR");
Console.WriteLine("=)\n=== Escolha o formato da data atual ===");
Console.WriteLine("1 - Formato Completo");
Console.WriteLine("2 - Data Simples (dd/mm/aaaa)");
Console.WriteLine("3 - Hora (24h)");
Console.WriteLine("4 - Data com Mês por Extenso");
Console.WriteLine("0 - Sair");
Console.Write("\nOpção desejada: ");

string input = Console.ReadLine();
DateTime now = DateTime.Now;

Console.WriteLine("\nResultado:");
            
switch (input)
{
    case "1":
        Console.WriteLine(now.ToString("F", culture));
        break;
    case "2":
        Console.WriteLine(now.ToString("d", culture));
        break;
    case "3":
        Console.WriteLine(now.ToString("HH:mm:ss"));
        break;
    case "4":
        Console.WriteLine(now.ToString("D", culture));
        break;
    case "0":
        Console.WriteLine("Encerrando...");
        break;
    default:
        Console.WriteLine("Opção inválida! Tente novamente.");
        break;
}

Console.WriteLine("\nPressione qualquer tecla para continuar...");
Console.ReadKey();