using System;

/*Ler quatro valores numéricos inteiros e apresentar o resultado dois a dois da adição e multiplicação entre os
valores lidos, baseando-se na utilização do conceito de propriedade distributiva. Dica: se forem lidas as variáveis
A, B, C e D, devem ser somados e multiplicados os valores de A com B, A com C e A com D; depois B com C, B
com D e por último C com D. Note que para cada operação serão utilizadas seis combinações. Assim sendo,
devem ser realizadas doze operações de processamento, sendo seis para as adições e seis para as
multiplicações. 
*/

class Program
{
    static void Main(string []args)
    {
        int n1,n2,n3,n4;

        Console.WriteLine("Bem vindo! \nPor favor digite o primeiro valor: ");
        n1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Por favor digite o segundo número: ");
        n2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Por favor digite o terceiro número: ");
        n3 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Por favor digito quarto número: ");
        n4 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"Soma resposta: \n{n1+n2} \n{n1+n3} \n{n2+n1} \n{n2+n3} \n{n3+n1} \n{n3+n2}");

        Console.WriteLine($"Multiplicação resposta: \n{n1*n2} \n{n1*n3} \n{n2*n1} \n{n2*n3} \n{n3*n1} \n{n3*n2}");

    }
}