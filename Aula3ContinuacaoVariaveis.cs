//nome de variável deve conter caracteres do alfabeto, numeros de 0 a 9 (desde que nao sejam o primeiro caractere, exemplo int 1banana, isso daria erro)
    //sem caracteres especiais no nome, pode ter underline (_), e não posso dar um nome que seja algo reservado da linguagem (tipo um nome de um comando ou bloco, isso da erro)
                //exemplo int using; isso daria erro porque using é uma estrutura de bloco da linguagem para chamar pacotes, assim como já informamos antes
//C# é uma linguagem bem rigida às especificações do comando, isso vale para variaveis também, não posso por exemplo tentar inserir um texto numa variável do tipo int ou float
//A partir da linha 48, iremos iniciar aplicações novas para variaveis, como por exemplo definir o valor dela dentro do código, e não predefinir como as demais
    //será com a variável da linha 27

//UM DETALHE IMPORTANTE EM VARIAVEIS DO TIPO FLOAT: devemos colocar um f depois do número que será armazenado, ou dará erro!


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//iremos entender namespace e class mais para frente, isso será de 
//orientação a objetos
namespace Aula3Continuacao //linha 17 e 18
{
    class Aula3Continuacao //linha 17 e 18
    {
        static void Main (string[] args) //FUNÇÃO PRINCIPAL MAIN! entenderemos funções mais para frente
        {

            //DESSA VEZ IREMOS FAZER UM PROGRAMA PARA SIMULAR O ANO DO IMPEACHMENT DA DILMA E SEU MANDATO!!!
            //variaveis devem ser escritas antes dos códigos, logo abaixo do bloco da função principal
            int duracaoMandato;//a unica coisa que precisaremos predefinir será se a variável é do tipo int, float, string etc
            int anoInicio = 2014; //essa variavel do tipo inteiro, pois a informação é um numero inteiro
            int anoFim = 2016;
            float abacaxi = 2.343f; //variavel totalmente aleatoria, apenas para usarmos uma do tipo float e colocarmos um número quebrado, não servirá para nada!
            string banana = "Bananas são muito boas!";//variavel totalmente aleatoria, apenas para usarmos uma do tipo string e colocarmos um texto, não servirá para nada!
            bool Impeachment = true;//vamos fazer o uso de uma variavel booleana, para verdadeiro ou falso agora
                                    //esse tipo de variável será extremamente utilizada em estruturas de repetição, como varemos mais para frente;
                                    //mas colocaremos por agora apenas para podermos falar que usamos na aula

            Console.WriteLine("Status do Impeachment: ");
            Console.WriteLine(Impeachment);
            Console.Write("Dilma se reelegeu em: ");
            Console.WriteLine(anoInicio);
            Console.Write("e ficou até: ");
            Console.WriteLine(anoFim); //se eu botar o nome de uma variável, no caso idade, dentro de um comando de imprimir texto na tela do usuário, sem o uso das aspas, ele 
                                  //imprimirá o dado armazenado da variavel na tela

            Console.Write("\n\n\n\n\n");//pulamos um monte de linha com esses \n, cada \n pula uma linha
            Console.WriteLine(abacaxi);
            Console.WriteLine(banana);

            duracaoMandato = anoFim - anoInicio;//repare que demos ordens dentro da programação do codigo de realizar uma conta para que o resultado dessa conta seja armazenado
                                                //dentro da variavel em branco, que não tem nada armazenado ainda, e que terá o resultado da subtração armazenado.
                                                //repare também que podemos utilizar variaveis para fazer as contas, pois o compilador irá interpretar os dados armazenados dentro
                                                //unica exigencia: todas as variaveis sendo trabalhadas sejam do mesmo tipo!

            Console.WriteLine("\n\n\n\n\n\n");
            Console.Write("O mandato da presidente durou: ");
            Console.Write(duracaoMandato);
            Console.WriteLine(" anos!");


            //ANTES DE ENCERRARMOS A AULA: vale a pena citar as constantes, que são variaveis que a gente não pode modificar no condigo, apenas predefinindo, exemplo abaixo
            const float PI = 3.1415;
            Console.WriteLine("\n\n\n\n\n");
            Console.WriteLine("O valor de PI eh: ");
            Console.WriteLine(PI);  //essa constante a gente não poderia só declarar, e depois pegar PI e tentar inserir valores dentro dos códigos posteriormente, devemos
                                    //inserir logo após declararmos e será esse valor até o fim, a aplicação disso pode ser para fazer algo mais seguro, para evitar modificações
                                    //na variavel, que podem atrapalhar o código
        }
    }


}