

using System;

/*Calcular e apresentar o valor do volume de uma lata de óleo, utilizando a fórmula:
V = 3.14159 * R * R * A
Onde as variáveis: V, R e A representam respectivamente o volume, o raio e a altura
*/

class Program
{
    
    static void Main(string[] args)
    {
    Console.WriteLine ("Bem vindo ao sistema de calculo de volume: ");

    Console.WriteLine("Digite o raio: ");
    if (!double.TryParse(Console.ReadLine(), out double r))
    {
    Console.WriteLine("Valor inválido! Insira um número válido.");
    return;
    }

    Console.WriteLine("Digite a altura: ");
    if (!double.TryParse(Console.ReadLine(), out double a))
    {
    Console.WriteLine("Valor inválido! Insira um número válido.");
    return;
    }

    double vol = 3.14159 * r * r * a;

    Console.WriteLine($"Volume resultante: {vol:F2}");
    }
}

