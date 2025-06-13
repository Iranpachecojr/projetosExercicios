using System;

//Escreva um programa que leia 3 números inteiros e imprima na tela os valores em ordem decrescente.

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Bem vindo ao Sistema \n ---------------- \n Por Favor digite o primeiro número: ");
        int n1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Por favor digite o segundo número: ");
        int n2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Digite o terceiro número");
        int n3 = Convert.ToInt32(Console.ReadLine());

        int maior, meio, menor;

        if (n1 >= n2 && n1 >= n3)
        {
            maior = n1;
            if (n2 >= n3)
            {
                meio = n2;
                menor = n3;
            }
            else
            {
                meio = n3;
                menor = n2;
            }

        }

        else if (n2 >= n1 && n2 >= n3)
        {
            maior = n2;
            if (n1 >= n3)
            {
                meio = n1;
                menor = n3;
            }
            else
            {
                meio = n3;
                menor = n1;
            }
        }
        else
        {
            maior = n3;
            if (n1 >= n2)
            {
                meio = n1;
                menor = n2;
            }
            else
            {
                meio = n2;
                menor = n1;
            }
        }

        Console.WriteLine($"\nSequência em ordem decrescente: {maior}, {meio}, {menor}");

    }
}
