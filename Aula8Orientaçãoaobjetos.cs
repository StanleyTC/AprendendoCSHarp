//representação do mundo real = seria nossa orientação a objetos
//objeto é criado a partir de uma classe
//classe / objeto = Físico/abstrato
//POO = programação orientada a objeto
//Uma classe possui:
    //propriedade (atributos)/características;
    //métodos (funções)
    //eventos (o que é feito durante uma ação)

//4 pilares de OO (orientação de objetos): encapsulamento/herança/abstração/polimorfismo
    //pilar de encapsulamento: agrupar o que faz sentido estar junto
    //pilar de abstração: esconder os detalhes, esconder os métodos
    //pilar de herança: uma classe herda todas as propriedades e métodos publicas de outra
    //pilar de polimorfismo: quando um método pode ser executado de formas diferentes

using System;

namespace Aula07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //primeiro devemos reservar um espaço para o objeto para usar ele
            //colocar um objeto na memória - instanciar uma classe
            Carro fusca = new Carro();
            //estou falando para criar um objeto carro na memória
            //niveis de acesso.public = publico     private = privado.não posso usar os atributos da classe sem que esteja public
            fusca.placa = "aaa";
            fusca.chassi = "111";
            fusca.peso = 1000;

            fusca.Andar();

            Moto suzuki = new Moto();
            suzuki.placa = "bbb";
            suzuki.chassi = "222";
            suzuki.peso = 200;
            suzuki.guidao = "funcional";
        }




        class Carro //criar um objeto carro
        {
            //no C#, a gente chama de classe
            //todas as variaveis de uma classe são chamadas de propriedades/atributos
            public string placa;        //se n definirmos se é public ou private, por padrão será private
            public string chassi;
            public string cor;
            public int peso;

            //dentro de uma classe, todas as funções são chamadas de métodos

            public void Andar() //parenteses vazio pode executar sem informação inserida, void é vazio, não devolve nada
            {
                ConsultarQuantidadeCombustivel(); //abstração - esconder detalhes
            }

            public void Seta()
            {

            }

            void ConsultarQuantidadeCombustivel()
            {

            }

        }




        class Moto : Carro //herança: todas as propriedades/atributos e métodos publicos do carro, a moto tem acesso
        {
            public string guidao;

        }
    }
}