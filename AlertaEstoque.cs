using System;

namespace Alerta_Estoque
{
    class Program
    {
        static void Main(string[] args)
        {
            double qtdMaxima,qtdAtual,resultados;
            string nomeProduto;

            Console.Clear();

            Console.WriteLine(">>>>>>>>>>>>>>> Olá, Bem Vindo ao Controle de Estoque <<<<<<<<<<<<<<<");
            

            Console.WriteLine("Digite o Nome de Produto");
            nomeProduto = Console.ReadLine();
            
            Console.WriteLine("Digite a Quantidade Atual do Produto");
            qtdAtual = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a Quantidade Máxima de Produto");
            qtdMaxima = double.Parse(Console.ReadLine());

            resultados = (qtdAtual / qtdMaxima)*100;

            Console.WriteLine(resultados.ToString("n2")+"%");

            if(resultados <= 12)
                Console.WriteLine("Comprar com Urgência");
            else if(resultados<=20)
                Console.WriteLine("Realizar Compra");
            else
                Console.WriteLine("Ponto de Utilização");



        }
    }
}