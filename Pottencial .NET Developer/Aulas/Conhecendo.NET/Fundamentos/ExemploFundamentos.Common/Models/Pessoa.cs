using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploFundamentos.Common.Models
{

    public class Pessoa
    {
         // Criando variáveis/atributos
        public string Nome { get; set; } 
        public int Idade { get; set; }

        // Criando métodos
        public void Apresentar(){
            // Se fizermos dessa forma podemos concatenar as variáveis e o texto.
            // Basta inserirmos o $ antes das aspas e com isso podemos colocar as variáveis entre colchetes.
            Console.WriteLine($"Olá, meu nome é {Nome}, e tenho {Idade} anos!");
        }
    }
}