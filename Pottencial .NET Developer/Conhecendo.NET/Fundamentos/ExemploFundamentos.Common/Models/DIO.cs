using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploFundamentos.Common.Models
{
    public class DIO
    {
        static void Main(string[] args)
        {
            int qt = int.Parse(Console.ReadLine()); //Recebendo valor
            string [] v = new string[2]; // Criando array para armazenar a divisão dos valores

            // TODO: Crie as outras condições necessárias para a resolução do desafio:
            for (int contador = 0; contador <= qt; contador++)
            {
                v = Console.ReadLine().Split(" ");
                string a = v[0];
                string b = v[1];

                if (b.Length > a.Length)
                    Console.WriteLine("nao encaixa");
                else if (a.EndsWith(b))
                    Console.WriteLine("encaixa");
                else
                    Console.WriteLine("nao encaixa");

            }

        }

    }
}
