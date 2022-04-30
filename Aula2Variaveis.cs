//variaveis, de maneira péssimamente descritas, seriam palavras que a gente insere como se fossem códigos, e dentro dessas palavras podemos armazenar alguma informação.
//Por exemplo: eu irei criar uma variavel chamada batata, ai dentro dela eu posso armazenar alguma informação, por exemplo batata = 3,141523265652353262365256
//ou seja, eu armazenei um número grande dentro da palavra batata
//por que que isso é útil? porque o tempo todo em programação iremos precisar chamar váriaveis, isso facilita muito do que ter que ficar declarando valor antes

//5 maneiras PRINCIPAIS de declarar variaveis:
//Int - armazena dados que são números inteiros. exemplo: int batata = 7675; (só pude armazenar um número inteiro dentro de batata, se eu botasse 13.5, daria erro)
//Float - armazena dados que são números flutuantes (tanto números inteiros, quanto quebrados). exemplo: float batata = 23.6;
    //podemos ainda utilizar Double ou Decimal, existem sim algumas diferenças, mas não utilizaremos para essa sequência de códigos nessas primeiras aulas
//Bool - esse é para identificar se uma condição de uma variavel é verdadeira ou falsa (true ou false): Bool batata = true (essa estrutura será utilizada mais em aulas posteriores)
//String - armazena textos. ex: String batata = "meu nome é jeremias e eu gosto de batatas";
//Char - apenas para uma única letra. ex Char batata = 'a'; se eu botar aa, vai dar erro. no Char devemos usar aspas simples ', no String aspas duplas ", ou dará erro


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//iremos entender namespace e class mais para frente, isso será de 
//orientação a objetos
namespace Aula1HelloWorld //linha 17 e 18
{
    class Aula1HelloWorld //linha 17 e 18
    {
        static void Main (string[] args) //FUNÇÃO PRINCIPAL MAIN! entenderemos funções mais para frente
        {
            //variaveis devem ser escritas antes dos códigos, logo abaixo do bloco da função principal
            int idade = 22; //essa variavel do tipo inteiro com o nome de idade está armazenando o número 22
            Console.Write("Minha idade é ");
            Console.Write(idade); //se eu botar o nome de uma variável, no caso idade, dentro de um comando de imprimir texto na tela do usuário, sem o uso das aspas, ele 
                                  //imprimirá o dado armazenado da variavel na tela
        }
    }


}