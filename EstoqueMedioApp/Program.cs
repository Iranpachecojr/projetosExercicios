using System;

//Faça um programa para calcular o estoque médio de uma peça, sendo que:
//ESTOQUE MÉDIO = (QUANTIDADE_MÍNIMA + QUANTIDADE_MÁXIMA) / 2

using System;

class Program 
{
    static void Main(string[] args)
    {
        double estoqueDep;
        double estoqueLoja;
        double mediaEstoque;
        string resp;

        Console.WriteLine("Bem-vindo ao sistema de cálculo de média do estoque geral!");

        do
        {
            Console.WriteLine("Deseja realizar o cálculo da média de estoque? (s/n)");
            resp = Console.ReadLine()?.ToLower(); // Converte para minúsculas para evitar inconsistências

            if (resp == "s")
            {
                Console.WriteLine("Por favor, digite os valores do estoque do depósito e da loja, respectivamente:");
                try
                {
                    estoqueDep = Convert.ToDouble(Console.ReadLine());
                    estoqueLoja = Convert.ToDouble(Console.ReadLine());
                    mediaEstoque = (estoqueDep + estoqueLoja) / 2;
                    Console.WriteLine($"Resultado da média geral: {mediaEstoque}");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Entrada inválida. Por favor, insira apenas números.");
                }
            }
            else if (resp == "n")
            {
                Console.WriteLine("Fim do programa. Obrigado por utilizar o sistema!");
            }
            else
            {
                Console.WriteLine("Opção inválida. Por favor, escolha 's' ou 'n'.");
            }

        } while (resp != "n");
    }
}