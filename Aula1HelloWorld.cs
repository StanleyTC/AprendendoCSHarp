//plataforma - conjunto de bibliotecas
//plataforma .NET = bibliotecas que utilizaremos em C#
//.NET pode ser utilizada por diversas linguagens de programação
//Linguagem C# criada logo após .NET
//C# é uma das linguagens mais bem portáveis do mundo

//vs code é mais para desenvolvimento web, vs community seria o mais
//indicado para C#

// chamarei os pacotes abaixo, alguns desnecessários para a aula de hoje
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
           
            Console.Write("Hello World!"); //primeiro comando, a estrutura Console.Write("") é para exibir um texto na tela do usuário, texto deve ser botado em aspas
            //Console.WriteLine("") com o acrescimo do Line, o comando será a mesma coisa, mas pulará linha na hora de exibir no terminal
            //outra forma de pular linha seria usando \n, da seguinte forma: Console.Write("Hello World!\n"); mas é meio chato ficar usando isso toda hora, melhor botar direto Console.Writeline("seu texto aqui");
            //caso não tenha entendido, pratique essa variedade de comandos, usando o \n, Console.WriteLine(""); e Console.Write(""), é bem facinho
        }
    }


}