using System;

/*3) Faça um programa para pagamento de comissão de vendedores de peças, levando-se em consideração que sua 
comissão será de 5% do total da venda e que você tem os seguintes dados: - Identificação do vendedor - Código da peça - Preço unitário da peça 
- Quantidade vendida*/

class Program
{
    static void Main(string[]Args)
    {
        string? vendedor1 = "Pedro";
        string? vendedor2 = "Carlos";
        string? vendedor3 = "Ana";
        decimal p1 = 9.99M;
        decimal p2 = 10.90M;
        decimal p3 = 5.99M;

        Console.WriteLine("Bem vindo ao Sistema\n ------------------------");
        Console.WriteLine("Digite o código do vendedor: (v1, v2, v3): ");
        string? codVend = Console.ReadLine();
    
        {
            Console.WriteLine("Código do vendedor infalido!");
            return;
        }
        string? codVendedor = codVend switch
        {
            "v1" => vendedor1,
            "v2" => vendedor2,
            "v3" => vendedor3,
            _ => "Desconhecido"        
        };

        {
            Console.WriteLine("Código vendedor invalido.");
            return;
        }
        Console.WriteLine($"Bem vindo: {codVendedor}");
        Console.WriteLine("Digite o código da Peça (p1, p2, p3): ");
        string codigoPeca = Console.ReadLine();

        Console.WriteLine("Digite o número de peças: ");
        if(!int.TryParse(Console.ReadLine(),out int quantidadeVendida))
        {
            Console.WriteLine("Quantidade invalida!");
            return;
        }

        decimal precoUnitario = codigoPeca switch
        {
            "p1" => p1,
            "p2" => p2,
            "p3" => p3,
            _ => 0
        };

        if (precoUnitario == 0)
        {
            Console.WriteLine("Código de peça invalido!");
            return;
        }

        decimal totalVendas = precoUnitario * quantidadeVendida;
        decimal comissao = totalVendas * 0.05M;

        Console.WriteLine($"Total da venda: {totalVendas:C}");
        Console.WriteLine($"Comissão da Venda: {comissao:C}");
    }
}