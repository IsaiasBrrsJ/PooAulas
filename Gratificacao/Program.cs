using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desafio8
{
    class Program
    {
        static void Main(string[] args)
        {


            new Gerente().ExibirGratificacao(500);
            new Analista().ExibirGratificacao(300);
            new Secretaria().ExibirGratificacao(100);

            Console.ReadKey();

        }
    }
}
