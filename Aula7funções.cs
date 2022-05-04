//aula 7 - uso de funções
//basicamente uma função é uma estrutura do nosso código que será responsável
//por toda a programação a parte, e poderemos fazer com que essa função
//entregue todos os calculos em uma variável, que será utilizada na main
//inclusive, aqui temos uma noção de que a main é uma função, que estávamos
//trabalhando o tempo todo

//cada função é um bloco que realiza uma série de programações, a main é a principal,
//onde geralmente chamamos a função
//em uma função, a gente leva variaveis da main como parametros para trabalhar
using System;

namespace aula6
{

	internal class Program
	{
	

		//vamos criar uma função
        //static vamos iniciar com static seguindo o MAIN
        //(para manter a comunicação)
        static int Maior(int n1, int n2, int n3)                       //aqui iniciamos a função, mas o código a gente começou a escrever
        {// acima botamos variaveis que trouxemos da função principal  //na main, portanto comece a ler o código a partir da linha 44, depois volte aqui
            int maiorNumero;                                           //eu poderia ter feito a função maior embaixo da main tbm, fiz aqui em cima apenas por aleatoriedade minha mesmo
            //criei a variavel numero maior para retornar a main uma variavel de retorno
            if (n1>n2 && n1>n3)
            {
                maiorNumero = n1;
            }
            else if(n2>n3)
            {
                maiorNumero = n2;
            }
            else
            {
                maiorNumero = n3;
            }
            return maiorNumero;
		}



    	static void Main(string[] args)
        {

            Console.WriteLine("Digite três números: ");

            int n1, n2, n3;

            n1 = int.Parse(Console.ReadLine());
            n2 = int.Parse(Console.ReadLine());
            n3 = int.Parse(Console.ReadLine());

            int Resultado = Maior(n1, n2, n3); //aqui está meu comando para importar todas as variaveis para a função
                                               //Maior, onde estará ocorrendo todas as contas

            Console.WriteLine("Maior = " + Resultado); //aqui mandei imprimir o resultado da função, que veio através da variavel maiorNumero


        }



        

	}

}