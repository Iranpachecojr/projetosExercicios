using System;
/*Ler uma temperatura em graus Celsius e apresentá-Ia convertida em graus Fahrenheit. A fórmula de conversão de 
temperatura a ser utilizada é F = (9 * C + 160) / 5, em que a variável F representa é a temperatura em graus 
Fahrenheit e a variável C representa é a temperatura em graus Celsius.
*/

class Program
{
    static void Main(string[]Args)
    {
        Console.WriteLine("Inicio do Programa \nPor favor digite o valor da temperatura em \ngraus Cesius:");
        double GrauCelsius = Convert.ToDouble(Console.ReadLine());
        double F = (9 * GrauCelsius + 160) / 5;

        Console.WriteLine($"Fahrenheit: {F}");

    }
}