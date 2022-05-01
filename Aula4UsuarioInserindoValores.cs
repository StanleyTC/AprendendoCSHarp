//Nessa aula, iremos dar um grande salto: iremos fazer um programa onde o usuário irá interagir diretamente com ele!
//para isso, iremos criar um programa onde o usuário terá que digitar coisas, de acordo com as instruções da tela, e ao fazer isso, o programa retornará algo a ele

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//iremos entender namespace e class mais para frente, isso será de 
//orientação a objetos
namespace Aula4usuario
{
    class Aula4usuario
    {
        static void Main (string[] args) //FUNÇÃO PRINCIPAL MAIN! entenderemos funções mais para frente
        {
            //variaveis devem ser escritas antes dos códigos, logo abaixo do bloco da função principal
            string nome = ""; //essa variavel será a que o usuario deverá inserir o nome dele. para deixar uma variavel string em branco, devemos
                         // colocar = "" para não dar erro


            Console.WriteLine("Por favor, insira seu nome completo: "); //inicialmente aplicaremos o que sabemos apenas para inserir uma mensagem na tela do usuario
            nome = Console.ReadLine(); //com esse comando, ReadLine, o usuario irá declarar o valor que será armazenado na variavel nome, e com isso
                                    //teremos o usuario interagindo com o código!
            Console.Write("Seu nome eh: ");
            Console.WriteLine(nome);
            //outra forma interessante seria Console.WriteLine("Seu nome eh: {0}", nome); esse metodo, eu estarei chamando a string com {0} dentro do texto, e fora, após
            //eu botar uma virgula, deverei escrever o nome da variavel string que estarei chamando, assim teremos o mesmo resultado!
            //se eu tiver que mandar imprimir 3 variaveis, ai usariamos {0}, {1}, {2}, cada indice para cada respectiva variavel, é bem interessante, qualquer coisa só
            //fazer treinos, é simples!

            //Agora, com esse contexto inserido, iremos aproveitar essa aula e entender mais sobre operadores matematicos utilizados na linguagem, que mexeremos muito
            //para brincar com as variaveis, assim como vimos na aula anterior, onde tivemos uma subtração

            //operadores:
                //subtração: -
                //soma: +
                //multiplicação: *
                //divisão: /
                //para falarmos ao nosso codigo qual conta fazer primeiro, botar entre (), assim como vimos em matematica basica
            //divisao entre dois inteiros, no C#, vai resultar num numero inteiro, isso é um problema, melhor tomar cuidado com isso, 
            //o melhor a se fazer é utilizar float ou double, ou colocar o f em um numero da divisão, mas sinceramente não prefiro trabalhar com isso

            float primeiro;
            float segundo; 
            float soma;

            Console.WriteLine("\n\n\n");
            Console.Write("por favor senhor ");
            Console.Write(nome);
            Console.WriteLine("Insira dois numeros para somarmos eles.\n");
            
            Console.WriteLine("Insira o primeiro número: "); //o modelo que conhecemos para armazenar o que o usuario digitar não é valido para int ou float, então para consertar,
            primeiro = float.Parse(Console.ReadLine());                   //deveremos colocar int.Parse() para int, ou float.Parse() para float

            Console.WriteLine("Insira o segundo número: ");
            segundo = float.Parse(Console.ReadLine());

            soma = primeiro + segundo;

            Console.Write("O resultado da soma eh: ");
            Console.WriteLine(soma);


        }
    }


}