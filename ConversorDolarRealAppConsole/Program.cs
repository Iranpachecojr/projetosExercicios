using System;

class Program
{
    static void Main(string[]Args)
    {
        decimal dolarCot = 5.00M; 
        decimal realCot;

        Console.WriteLine("Bem vindo ao sistema conversor");
        Console.WriteLine("Porfavor digite o valor:" );
        realCot = Convert.ToDecimal(Console.ReadLine());

        decimal valorConvt = realCot*dolarCot;

        Console.WriteLine( "Valor resultante da conversão:" +valorConvt);

    }
}
