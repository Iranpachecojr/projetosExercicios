using System;

/*) Efetuar o cálculo da quantidade de litros de combustível gasta em uma viagem, utilizando um automóvel que faz 
12 Km por litro. Para obter o cálculo, o usuário deve fornecer o tempo gasto na viagem e a velocidade média. 
Desta forma, será possível obter a distância percorrida com a fórmula DISTANCIA = TEMPO * VELOCIDADE. 
Tendo o valor da distância, basta calcular a quantidade de litros de combustível utilizada na viagem com a 
fórmula: LITROS_USADOS = DISTANCIA / 12. O programa deve apresentar os valores da velocidade média, 
tempo gasto, a distância percorrida e a quantidade de litros utilizada na viagem. Dica: trabalhe com valores reais.
*/

class Program
{
    static void Main(string []args)
    {
         
        Console.WriteLine("oi \nBem vindo ao app de gasto de combustivel n\entre com o valor do tempo médio:");
        if(!double.TryParse(Console.ReadLine(), out double tempo))
        {
            Console.WriteLine("Número invalido. Por favor inserir número válido");
            return;
        }
        Console.WriteLine("entre com o valor da velocidade média:");
        if(!double.TryParse(Console.ReadLine(), out double velocidade))
        {
            Console.WriteLine("Valor Invalido! Por favor insira um número válido!");
            return;
        }
        double distancia = tempo*velocidade;
        double litrosUsados = distancia / 12;

        Console.WriteLine($"Sua distancia: {distancia} \nTempo gasto: {tempo} \nVelociade média: {velocidade} \nlitros Usados: {litrosUsados}");

    }
}
