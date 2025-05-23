using System;

/*Faça um algoritmo que leia a idade de uma pessoa expressa em anos, meses e dias e escreva a idade dessa 
pessoa expressa apenas em dias. Considerar ano com 365 dias e mês com 30 dias
*/

class Program
{
    static void Main (string[] args)
    {
        Console.WriteLine("Por favor Digite sua indade em anos: ");
        if(!int.TryParse(Console.ReadLine(), out int QuantAnos));

        Console.WriteLine("Por favor digite sia idade em meses: ");
        if(!int.TryParse(Console.ReadLine(), out int QuantMeses));

        Console.WriteLine("Por favor digite dias: ");
        if(!int.TryParse(Console.ReadLine(), out int QuantDias));

        int DiasEmAnos = QuantAnos * 365;
        int DiasEmMeses = QuantMeses * 30;
        int DiasEmDias = QuantDias;

        int TotalDias = DiasEmAnos + DiasEmMeses + DiasEmDias;

        Console.WriteLine($"Você possui {TotalDias}");
    }
}